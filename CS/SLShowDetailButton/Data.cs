using System.Collections.Generic;

namespace WpfApplication26
{

    public class Category
    {
        private string name;
        private List<Product> products;
        public Category(string name)
        {
            this.name = name;
            products = new List<Product>();
        }
        public string Name { get { return name; } set { name = value; } }
        public List<Product> Products { get { return products; } }
    }
    public class Product {
        private string name;
        private double price;
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }
    }

    public class DataSource
    {
        private List<Category> categories;
        public DataSource()
        {
            categories = new List<Category>();
            categories.Add(new Category("First"));
            categories[0].Products.Add(new Product("Product 1.1", 10));
            categories[0].Products.Add(new Product("Product 1.2", 20));
            categories[0].Products.Add(new Product("Product 1.3", 30));
            categories[0].Products.Add(new Product("Product 1.4", 40));
            categories.Add(new Category("Second"));
            categories[1].Products.Add(new Product("Product 2.1", 10));
            categories[1].Products.Add(new Product("Product 2.2", 20));
            categories.Add(new Category("Third"));
            categories[2].Products.Add(new Product("Product 3.1", 10));
            categories[2].Products.Add(new Product("Product 3.2", 20));
            categories[2].Products.Add(new Product("Product 3.4", 40));
            categories.Add(new Category("Fourth"));
            categories[3].Products.Add(new Product("Product 4.1", 10));
            categories[3].Products.Add(new Product("Product 4.2", 20));
            categories[3].Products.Add(new Product("Product 4.3", 30));
            categories[3].Products.Add(new Product("Product 4.4", 40));
        }
        public List<Category> Categories { get { return categories; } }
    }
}