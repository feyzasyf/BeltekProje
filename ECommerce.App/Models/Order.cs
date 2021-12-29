using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.App.Models
{

    [Table("Orders")]
    public class Order
    {

        public int OrderId { get; set; }      

        public string CustomerEmail { get; set; }

        public string CustomerName { get; set; }       

        public string  Address { get; set; }

        public DateTime OrderDate { get; set; }


        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
