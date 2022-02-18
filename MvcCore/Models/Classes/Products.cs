using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCore.Models.Classes
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal  UnitPrice { get; set; }
        [ForeignKey("CategoryId")]
        public Categories Categories  { get; set; }

    }
}
