using Online_Platform.Infrastructure.Constant;
using Online_Platform.Models.WebModels;

namespace Online_Platform.Infrastructure.Helpers
{
    

    public static class StyleHelpers
    {
        public static string ToStyle(this string actionName)
            => WebConstants.Styles.ContainsKey(actionName)
            ? WebConstants.Styles[actionName]
            : WebConstants.OutlinePrimaryStyle;

        public static string ToStyle(this FormActionEnum action)
            => action.ToString().ToStyle();
    }
}
