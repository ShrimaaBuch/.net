using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practical_6.Models;

namespace Practical_6.Controllers
{
    public class ProductController : Controller
    {
        public List<Product> GetProducts()
        {
            Product p1 = new Product();
            p1.ProductId = 1;
            p1.ProductName = "Laptop";
            p1.Category = "Electronics";
            p1.Description = "HP Laptop";
            p1.Price = 50000;
            p1.Image = "https://images.unsplash.com/photo-1541807084-5c52b6b3adef?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";
            p1.Quantity = 10;

            Product p2 = new Product();
            p2.ProductId = 2;
            p2.ProductName = "Mobile";
            p2.Category = "Electronics";
            p2.Description = "Samsung Mobile";
            p2.Price = 25000;
            p2.Image = "https://images.unsplash.com/photo-1598327105666-5b89351aff97?q=80&w=627&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";
            p2.Quantity = 20;

            Product p3 = new Product();
            p3.ProductId = 3;
            p3.ProductName = "Headphones";
            p3.Category = "Accessories";
            p3.Description = "Wireless Headphones";
            p3.Price = 3000;
            p3.Image = "https://plus.unsplash.com/premium_photo-1679513691474-73102089c117?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8SGVhZHBob25lfGVufDB8fDB8fHww";
            p3.Quantity = 15;

            List<Product> list = new List<Product>();

            list.Add(p1);
            list.Add(p2);
            list.Add(p3);

            return list;
        }

        public ActionResult Index()
        {
            return View(GetProducts());
        }

        public ActionResult Details(int id)
        {
            Product product = GetProducts().FirstOrDefault(p => p.ProductId == id);

            return View(product);
        }
    }
}