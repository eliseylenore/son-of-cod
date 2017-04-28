using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
    [Table("MarketingPages")]
    public class MarketingPage
    {
        [Key]
        public int Id { get; set; }
        public string BannerImageUrl { get; set; }
        public string BannerTitle { get; set; }
        public string SummaryTitle { get; set; }
        public string SummaryText { get; set; }
        public string SummaryImageUrl { get; set; }
        public string ProductsTitle { get; set; }
        public  ICollection<Product> Products { get; set; }
        public string NewsTitle { get; set; }
        public string NewsSummary { get; set; }
        public string NewsImageUrl { get; set; }
    }
}
