namespace Online_Platform.Services
{
    using System.Collections.Generic;
    using Online_Platform.Services.Models.ShoppingCart;

    public interface IShoppingCartManager
    {
        void AddItemToCart(string shoppingCartId, int courseId);

        void EmptyCart(string shoppingCartId);

        IEnumerable<CartItem> GetCartItems(string shoppingCartId);

        void RemoveItemFromCart(string shoppingCartId, int courseId);
    }
}
