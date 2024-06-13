namespace Online_Platform.Services.Models.ShoppingCart
{
    using Online_Platform.Mapping;
    using Online_Platform.Models;
    using System;
    using System.ComponentModel.DataAnnotations;
  

    public class CartItemDetailsServiceModel : IMapFrom<Course>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
    }
}
