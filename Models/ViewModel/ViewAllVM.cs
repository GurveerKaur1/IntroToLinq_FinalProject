using Microsoft.AspNetCore.Mvc.Rendering;

namespace IntroToLinq_FinalProject.Models.ViewModel
{
    public class ViewAllVM
    {
        public List<SelectListItem> Brand1 { get; } = new List<SelectListItem>();
       public List<SelectListItem> year { get; } = new List<SelectListItem>();

        public string BrandId1 { get; set; }

        public ViewAllVM(HashSet<Brand> brand1)
        {
            foreach(Brand b in brand1)
            {
                Brand1.Add(new SelectListItem(b.Name, b.Id.ToString()));
            }
        }

        public Brand brand2 { get; set; }
        public ViewAllVM(string id1, HashSet<Brand> brands)
        {
            brand2 = brands.First(b1 => b1.Id == Int32.Parse(id1));
        }
        public ViewAllVM()
        {

        }


    }
}
