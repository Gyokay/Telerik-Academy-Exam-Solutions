namespace Cosmetics.Products
{
    using Contracts;
    using System.Collections.Generic;

    class Category : ICategory
    {
        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.Products = products;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                //TO DO: validation
                this.name = value;
            }
        }

        public ICollection<IProduct> Products
        {
            get { return this.products; }
            private set
            {
                this.products = new List<IProduct>();
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {

        }

        public void RemoveCosmetics(IProduct cosmetics)
        {

        }

        public string Print()
        {
            return;
        }
    }
}
