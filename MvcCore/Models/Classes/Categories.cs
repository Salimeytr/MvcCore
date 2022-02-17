using System.ComponentModel.DataAnnotations;

namespace MvcCore.Models.Classes
{
    public class Categories
    {
        [Key]
        public int CategoryId  { get; set; }
        public string CategoryName { get; set; } 

    }
}
