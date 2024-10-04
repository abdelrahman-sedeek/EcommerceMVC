using EcommerceMVC.Contexts;
using EcommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ProgramContext _context;
        public CategoryController( ProgramContext context) {

            _context= context;

        }
        
        public IActionResult Index()
        {
          List<Category> data= _context.categories.ToList();
            return View(data);
        }
        
        public IActionResult Create()
        {

            return View();
        }
   
        [HttpPost]
        
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid) { 
                _context.categories.Add(category);
                _context.SaveChanges();
                
                TempData["success"] = "Category Added successfully";
        
                return RedirectToAction("Index");
            }

            return View();
        } 
        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0) {
                return NotFound();
            }
            
            Category? data= _context.categories.FirstOrDefault(c => c.Id == Id);
            return View(data);
        }
        [HttpPost]
        
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid) { 
                _context.categories.Update(category);
                _context.SaveChanges();
                TempData["success"] = "Category Updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        
        [HttpPost]
        
        public IActionResult Delete(int ?Id)
        {
            
            Category ? obj= _context.categories.Find(Id);
            if (obj == null) {
                return NotFound();
            }
                _context.categories.Remove(obj);
                _context.SaveChanges();
            TempData["success"] = "Category Deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
