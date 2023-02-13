using Microsoft.AspNetCore.Mvc;
using IntroToLinq_FinalProject.Data;
using IntroToLinq_FinalProject.Models;
using IntroToLinq_FinalProject.Models.ViewModel;

using System.Linq;
using AspNetCore;

namespace IntroToLinq_FinalProject.Controllers
{
    public class LaptopController : Controller
    {
        public IActionResult Index()
        {
            return View(Context.Laptops);
        }
       
         
        public IActionResult MostExpensiveLaptop()
        {
            List<Laptop> laptops= Context.Laptops.Where(laptop =>
            {
                return true;
            }).ToList();

            return View( laptops.OrderBy(l => l.PriceInDollars).ToList());
        }

        public IActionResult MostCheapestLaptop()
        {
            List<Laptop> laptops = Context.Laptops.Where(laptop =>
            {
                return true;
            }).ToList();

            return View(laptops.OrderByDescending(l => l.PriceInDollars).ToList());
        }

        public IActionResult InBudget(int lower, int upper)
        {
            ViewBag.PageTitle = $"Laptops in Budget between ${lower} million and ${upper} million";

            if (lower < 0 || upper < 0 || upper < lower)
            {
                ViewBag.Message = "Cannot have a negative budget, or an upper budget lower than a lower budget.";
                return View("Index");
            }
            else
            {
                HashSet<Laptop> laptops = Context.Laptops.Where(m =>
                {
                    return m.PriceInDollars >= lower && m.PriceInDollars <= upper;
                }).ToHashSet();
                ViewBag.MovieCount = laptops.Count;
                return View("Index", laptops);
            }
        }
      public IActionResult CompareLaptop(string id1, string id2)
        {
            try
            {
                CompareLaptopVM vm = new CompareLaptopVM(id1, id2, Context.Laptops);
                return View(vm);
            }
            catch
            {
                CompareLaptopVM vm = new CompareLaptopVM(Context.Laptops);
                return View(vm);
            }
        }

        [HttpPost]
        public IActionResult CompareLaptop(CompareLaptopVM vm)
        {
            Laptop laptop1 =  Context.Laptops.First(m => m.Id == Int32.Parse(vm.LaptopId1));
            Laptop laptop2 = Context.Laptops.First(m => m.Id == Int32.Parse(vm.LaptopId2));
            return RedirectToAction("CompareLaptop", new { id1 = vm.LaptopId1, id2 = vm.LaptopId2 });

        }

        public IActionResult GetType()
        {
            List<Laptop> laptops = Context.Laptops.Where(laptop => {
                return laptop.TypeOfLaptop == laptop.TypeOfLaptop;
            }).ToList();
                return View("Index", laptops);
            

        }

        public IActionResult Create()
        {
            
            return View();
        }

        //to add the laptop to the brand
        [HttpPost]
        public IActionResult Create(int laptopId, int brandId)
        {
            Brand brand = Context.Brands.First(b => b.Id == brandId);
            Laptop laptop = Context.Laptops.First(l => l.Id == laptopId);
            brand.AddLaptop(laptop);
            Context.Laptops.Add(laptop);
            return RedirectToAction("Index", new {laptopId = laptop.Id});
        }
    }
}
