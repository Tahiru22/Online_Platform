using System.ComponentModel.DataAnnotations;

namespace Online_Platform.Models
{
    public enum PaymentType
    {
        [Display(Name = "Debit/Credit Card")]
        DebitCreditCard = 0,
        [Display(Name = "Bank Transfer")]
        BankTransfer = 1,
        Voucher = 2,
        Cash = 3
    }
}
