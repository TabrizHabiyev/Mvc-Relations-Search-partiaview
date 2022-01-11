using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Select_Option_Relations.DAL;
using Select_Option_Relations.Models;
using Select_Option_Relations.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Select_Option_Relations.Controllers
{
    public class HomeController : Controller
    {
         private readonly Context _context;
         public HomeController(Context context)
         {
            _context = context;
         }
         
     // Products serach 
        
        public IActionResult LoadMore(int skip)
        {
            IEnumerable<Products> products= _context.products.Include(c=>c.products).Skip(skip).Take(8).ToList();
            return Json(_context.products.Skip(skip).Take(5).ToList());
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Products> products = _context.products
                .Include(c => c.products)
                .Where(p => p.Name.ToLower().Contains(search.ToLower()))
                .OrderByDescending(p => p.Id)
                .Take(8)
                .ToList();
            return PartialView("_SearchPartial", products);
        }

     // product search son


        ///Relation model and brand

        public IActionResult Index()
        {
            List<CarModel> carsModel = _context.carModels.ToList();
            HomeVM homeVm = new HomeVM();

            homeVm.carModels = carsModel;
            return View(homeVm);
        }

        public IActionResult showBrands(int modelsId)
        {
            IEnumerable<CarBrand> carBrands = _context.carBrands
               .Where(x => x.ModelId == modelsId)
               .ToList();
            return PartialView("_ChangePartial",carBrands);
        }

        ///Relation model and brand son
    }
}
