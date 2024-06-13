using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Models.Orders
{

    public class OrderItemServiceModel : IMapFrom<OrderItem>
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public decimal Price { get; set; }
    }
}
