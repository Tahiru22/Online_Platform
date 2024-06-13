namespace Online_Platform.Models.WebModels.ShoppingCart
{
    using System.ComponentModel.DataAnnotations;
    

    public class CheckoutFormModel
    {
        [Display(Name = "Payment method")]
        [Required]
        public PaymentType? PaymentMethod { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
