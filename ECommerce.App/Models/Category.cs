using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.App.Models
{

    [Table("Categories")]
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }
    }
}
