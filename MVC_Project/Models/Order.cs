using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project
{
    public class Order
    {
        public Order() { CustomerId = Guid.NewGuid().ToString(); }

        [Key]
        public int OrderId { get; set; }

        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
