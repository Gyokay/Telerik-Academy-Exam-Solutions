namespace Cosmetics.Products
{
    using Contracts;
    using Common;

    public abstract class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;
        private uint milliliters;

        public Product(string name, string brand,
                        decimal price, GenderType gender, uint millilliters)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            this.Milliliters = milliliters;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validate(value, 3, 10);

                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            private set
            {
                Validate(value, 2, 10);

                this.brand = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set { this.price = value; }
        }

         public GenderType Gender
        {
            get { return this.gender; }
            private set { this.gender = value; }
        }

        public uint Milliliters
        {
            get { return this.milliliters; }
            private set
            {
                this.milliliters = value;
            }
        }

        public string Print()
        {
            return;
        }

        static void Validate(string value, int min, int max)
        {
            string errMessage = string.Format("Product name must be between {0} and {1} symbols long!", min, max);
            Validator.CheckIfStringIsNullOrEmpty(value, errMessage);
            Validator.CheckIfStringLengthIsValid(value, max, min, errMessage);
        }
    }
}
