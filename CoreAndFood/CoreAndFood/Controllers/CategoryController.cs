using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{

    /*Validation ekleme adımları :
    1-) İlgili sınıfın ilgili alanına required yazılır. ([Required(ErrorMessage = "Category Name Not Empty")])
    2-)Controller da doğrulama kontrol edilir if ile.
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
    3-)View tarafında da uygulamak gerekir.
    
     */
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
     
        public IActionResult Index()
        {
            
            return View(categoryRepository.TList());
        }

        [HttpGet] //attribitue
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category ct)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            categoryRepository.TAdd(ct);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CategoryGet(int id)
        {
            var x = categoryRepository.TGet(id);

            Category ct = new Category()
            {
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription,
                CategoryID = x.CategoryID
            };      
            return View(ct);
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category p)
        {
            var x = categoryRepository.TGet(p.CategoryID); //güncellemek istediğimiz değerin IDsıini almış oluyoruz.
            x.CategoryName = p.CategoryName;
            x.CategoryDescription = p.CategoryDescription;
            //x.Status = true;
            categoryRepository.TUpdate(x); //p yi xe atadık.
            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(int id)
        {
            var x = categoryRepository.TGet(id);
            //x.Status=false;
            categoryRepository.TUpdate(x); //p yi xe atadık.
            return RedirectToAction("Index");
        }
    }
}
