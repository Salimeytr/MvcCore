using Microsoft.AspNetCore.Mvc;
using MvcCore.Models.Classes;
using MvcCore.Models.Data;
using System.Linq;

namespace MvcCore.Controllers
{
    public class CategoriesController : Controller
    {
        ProductContext _db;
        Categories _categories;

        public CategoriesController(ProductContext db,Categories categories)
        {
            _db = db;
            _categories = categories;
        }
        public IActionResult List ()
        {
            return View(_db.Set<Categories>().ToList());

        }
        [HttpGet]
        public IActionResult Create ()
        {
            //Categories cat = new Categories();
            //return View(cat);
            return View(_categories);

        }
        [HttpPost]
        public IActionResult Create(Categories model)
        {
            _db.Set<Categories>().Add(model);
            _db.SaveChanges();
             return RedirectToAction("List"); 

        }


    }
}
