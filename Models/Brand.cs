using IntroToLinq_FinalProject.Data;
namespace IntroToLinq_FinalProject.Models
{
    public class Brand
    {
        private readonly int _id;
        public int Id { get { return _id; } }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 0)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Model name must be atleast one character");
                }
            }
        }

       private HashSet<Laptop> _laptop = new HashSet<Laptop>();

        public HashSet<Laptop> GetLaptop()
        {
            return _laptop;
        }
        public HashSet<Laptop> Laptops  = new HashSet<Laptop>();   
        public void AddLaptop(Laptop laptop)
        {
            Laptops.Add(laptop);
        }

        public Laptop Laptop { get; set; }
        public Brand()
        {
            _id = Context.GetIdCount();
        }

        public Brand(string name)
        {
            _id = Context.GetIdCount();
            Name = name;
        }
        public Brand(string name, Laptop laptop)
        {
            _id = Context.GetIdCount();
            Name = name;
            Laptop = laptop;
        }
    }
}
