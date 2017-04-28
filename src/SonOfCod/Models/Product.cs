using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public virtual MarketingPage MarketingPage { get; set; }
    }
}
