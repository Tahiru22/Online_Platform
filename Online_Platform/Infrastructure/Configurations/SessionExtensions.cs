namespace Online_Platform.Infrastructure.Configurations
{
    using System;
    using Microsoft.AspNetCore.Http;
    using Online_Platform.Infrastructure.Constant;

    public static class SessionExtensions
    {
        public static string GetOrSetShoppingCartId(this ISession session)
        {
            var shoppingCartId = session.GetString(WebConstants.ShoppingCartKey);
            if (shoppingCartId == null)
            {
                shoppingCartId = Guid.NewGuid().ToString();
                session.SetString(WebConstants.ShoppingCartKey, shoppingCartId);
            }

            return shoppingCartId;
        }
    }
}
