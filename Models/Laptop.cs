using IntroToLinq_FinalProject.Data;
namespace IntroToLinq_FinalProject.Models
{
    public class Laptop
    {

        private readonly int _id;
        public int Id { get { return _id; } }   
        private string _modelName;
        public string ModelName 
        {
            get { return _modelName; }
            set
            {
                if(value.Length > 0)
                {
                    _modelName = value;
                }
                else
                {
                    throw new Exception("Model name must be atleast one character");
                }
            }
        }

        //private string _brand;
        //public string Brand
        //{
        //    get { return _brand; }
        //    set
        //    {
        //        if(value.Length > 0)
        //        {
        //            _brand = value;
        //        }
        //        else
        //        {
        //            throw new Exception("Brand name must be atleast one character");
        //        }
        //    }
        //}

        public Brand Brand { get; set; }

        private int _priceInDollars;

        public int PriceInDollars
        {
            get { return _priceInDollars;}
            set
            {
                if(value >=0)
                {
                    _priceInDollars = value;
                }
                else
                {
                    throw new Exception("Price cannot be less than zero");
                }
            }
        }

        public DateTime YearOfMake { get; set; }

        public TypeOfLaptop TypeOfLaptop { get; set; }

        private int _quantityInTheStock;

        public int QuantityInTheStock { get { return _quantityInTheStock;}  }

        public Laptop()
        {
            _id = Context.GetIdCount();
        }
        public Laptop( string modelName,Brand brand, int priceInDollars,  DateTime yearOfMake, TypeOfLaptop type, int quantityInTheStock)
        {
            _id = Context.GetIdCount();
          
            ModelName = modelName;
           Brand = brand;
          
            PriceInDollars = priceInDollars;
            YearOfMake = yearOfMake;
            TypeOfLaptop = type;
            _quantityInTheStock = quantityInTheStock;
        }
    }
}
