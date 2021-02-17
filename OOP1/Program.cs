using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product();
            pr1.Id = 1;
            pr1.CategoryId = 2;
            pr1.ProductName = "Masa";
            pr1.UnitPrice = 500;
            pr1.UnitsInStock = 3;

            Product pr2 = new Product { Id = 2, CategoryId = 5, UnitPrice = 5, UnitsInStock= 4, ProductName="Kalem" };

            ProductManager prma = new ProductManager();
            prma.Add(pr1);
           
        }
    }
}
