namespace Cosmetics.Products
{
    using Contracts;
    using Common;

    public class Shampoo : Product, IProduct, IShampoo
    {
        private UsageType usage;

        public Shampoo(string name, string brand,
                        decimal price, GenderType gender,
                        uint milliliters, UsageType usage) : base(name, brand, price, gender, milliliters)
        {
            this.Usage = usage;
        }

        public UsageType Usage
        {
            get { return this.usage; }
            private set { this.usage = value; }
        }

        

        
    }
}
