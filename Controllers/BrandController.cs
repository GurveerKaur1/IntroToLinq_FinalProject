using Microsoft.AspNetCore.Mvc;
using IntroToLinq_FinalProject.Data;
using IntroToLinq_FinalProject.Models;
using System.Linq;
using IntroToLinq_FinalProject.Models.ViewModel;

namespace IntroToLinq_FinalProject.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View(Context.Brands);
        }

      
        public IActionResult ViewAll(string id1)
        {
            try
            {
                ViewAllVM vm = new ViewAllVM(id1, Context.Brands);
                return View(vm);
            }
            catch
            {
                ViewAllVM vm = new ViewAllVM( Context.Brands);
                return View(vm);
            }
        }
        public IActionResult GetLaptops(int id1)
        {
            Brand brand1 = Context.Brands.First(m => m.Id == id1);
            return View(brand1);
        }

        [HttpPost]
        public IActionResult ViewAll(ViewAllVM vm)
        {
           Brand brand1 = Context.Brands.First(m => m.Id == Int32.Parse(vm.BrandId1));
            return RedirectToAction("GetLaptops", new { id1 = vm.BrandId1 });

        }

        public IActionResult Sort()
        {
            List<Laptop> laptops = Context.Laptops.Where(laptop =>
            {
                return true;
            }).ToList();

            return View(laptops.OrderBy(l => l.PriceInDollars).ToList());
        }

       
    }
}
