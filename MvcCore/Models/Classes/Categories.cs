using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcCore.Models.Classes
{
    public class Categories
    {
        public Categories()
        {
            Products= new  HashSet<Products>();
        }

        [Key]
        public int CategoryId  { get; set; }
        [Required(ErrorMessage ="Kategori adı boş bırakılamaz.")] //Alanı boş geçmemesi için zorunlu alan Yeni kayıt ve güncelleme yaparken alanı boş geçmemeyi sağlar
        [MinLength(3,ErrorMessage ="En az 3 karakterli olmalı.")]
        
        public string CategoryName { get; set; }
        public ICollection<Products> Products  { get; set; }

    }
}
