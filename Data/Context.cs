using IntroToLinq_FinalProject.Models;
namespace IntroToLinq_FinalProject.Data
{
    public static class Context
    {
        public static  HashSet<Laptop>  Laptops = new HashSet<Laptop>();

        public static HashSet<Brand> Brands = new HashSet<Brand>();


        // ===== Methods
        private static int _idCount = 0;
        public static int GetIdCount()
        {
            _idCount++;
            return _idCount;
        }
        private static void _seedMethod() {

            // seed brand
            Brand Dell = new Brand("Dell");
            Brand Lenovo = new Brand("Lenovo");
            Brand Apple = new Brand("Apple");
            Brands.Add(Dell);
            Brands.Add(Lenovo);
            Brands.Add(Apple);

            //seed laptop
            Laptop Latitude = new Laptop("Latitude",Dell, 639, new DateTime(1988, 1, 1), TypeOfLaptop.New, 5);
            Laptop XPS = new Laptop("XPS", Dell, 459, new DateTime(2000, 1, 1), TypeOfLaptop.Refurbished, 6);
            Laptop ChromeBook = new Laptop("ChromeBook", Dell, 580, new DateTime(2008, 1, 1), TypeOfLaptop.Rental, 8);
            Laptop Alienware = new Laptop("Alienware", Dell, 790, new DateTime(2005, 1, 1), TypeOfLaptop.Refurbished, 12);
            Laptop XPS13 = new Laptop("XPS13", Dell, 1100, new DateTime(1987, 1, 1), TypeOfLaptop.New, 15);
            Laptop Macbook = new Laptop("Mackbook",Lenovo, 1300, new DateTime(1968, 1, 1), TypeOfLaptop.Rental, 25);
            Laptop  PowerBook = new Laptop("PowerBook", Lenovo, 890, new DateTime(2018, 1, 1), TypeOfLaptop.Refurbished, 45);
            Laptop Pismo = new Laptop("Pismo", Lenovo, 500, new DateTime(2017, 1, 1), TypeOfLaptop.Rental, 10);
            Laptop Titanium = new Laptop("Titanium", Lenovo, 600, new DateTime(2004, 1, 1), TypeOfLaptop.New, 4);
            Laptop MacBook14 = new Laptop("MacBook", Lenovo, 789, new DateTime(1999, 1, 1), TypeOfLaptop.New, 9);
            Laptop Flex = new Laptop("Flex",Apple, 1245, new DateTime(1997, 1, 1), TypeOfLaptop.New, 14);
            Laptop Ideapad = new Laptop("Ideapad", Apple, 1090, new DateTime(2007, 1, 1), TypeOfLaptop.Refurbished, 27);
            Laptop Legion = new Laptop("Legion", Apple, 759, new DateTime(2003, 1, 1), TypeOfLaptop.New, 23);
            Laptop Yoga = new Laptop("Chromebook", Apple, 800, new DateTime(1995, 1, 1), TypeOfLaptop.Rental, 11);
            Laptop Thinkpad = new Laptop("Thinkpad", Apple, 650, new DateTime(2001, 1, 1), TypeOfLaptop.New, 17);
            Laptops.Add(Latitude);
            Laptops.Add(XPS);
            Laptops.Add(ChromeBook);
            Laptops.Add(Alienware);
            Laptops.Add(XPS13);
            Laptops.Add(Macbook);
            Laptops.Add(PowerBook);
            Laptops.Add(Pismo);
            Laptops.Add(Titanium);
            Laptops.Add(MacBook14);
            Laptops.Add(Flex);
            Laptops.Add(Ideapad);
            Laptops.Add(Legion);
            Laptops.Add(Yoga);
            Laptops.Add(Thinkpad);
            Dell.Laptops.Add(Latitude);
            Dell.AddLaptop(Latitude);
            Dell.AddLaptop(XPS);
            Dell.AddLaptop(ChromeBook);
            Dell.AddLaptop(Alienware);
            Dell.AddLaptop(XPS13);
            Lenovo.AddLaptop(Macbook);
            Lenovo.AddLaptop(PowerBook);
            Lenovo.AddLaptop(Pismo);
            Lenovo.AddLaptop(MacBook14);
            Lenovo.AddLaptop(Titanium);
            Apple.AddLaptop(Legion);
            Apple.AddLaptop(Yoga);
            Apple.AddLaptop(Thinkpad);
            Apple.AddLaptop(Ideapad);
            Apple.AddLaptop(Flex);

         }
        static Context()
        {
            _seedMethod();
        }
    }

    public enum TypeOfLaptop
    {
        New,
        Refurbished,
        Rental
    }

  

}
