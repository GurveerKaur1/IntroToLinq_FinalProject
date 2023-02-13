using Microsoft.AspNetCore.Mvc.Rendering;

namespace IntroToLinq_FinalProject.Models.ViewModel
{
    public class CompareLaptopVM
    {
        public List<SelectListItem> Laptop1 { get; } = new List<SelectListItem>();

       // public Laptop laptop { get; set; }

        public string LaptopId1 { get; set; }
        public string LaptopId2 { get;set; }

        public CompareLaptopVM(HashSet<Laptop> laptop1)
        {
            foreach(Laptop l in laptop1)
            {
                Laptop1.Add(new SelectListItem(l.ModelName, l.Id.ToString()));
            }
        }

        public Laptop laptop2 { get; set; }
        public Laptop laptop3 { get; set; }
        public CompareLaptopVM(string id1, string id2, HashSet<Laptop> laptop)
        {
            foreach(Laptop l in laptop)
            {
                Laptop1.Add(new SelectListItem(l.ModelName, l.Id.ToString()));
            }

            laptop2 = laptop.First(l1 => l1.Id == Int32.Parse(id1));
            laptop3 = laptop.First(l1 => l1.Id == Int32.Parse(id2));

        }

        public CompareLaptopVM()
        {

        }
    }
}
