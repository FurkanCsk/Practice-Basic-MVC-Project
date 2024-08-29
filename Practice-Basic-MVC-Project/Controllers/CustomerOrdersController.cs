using Microsoft.AspNetCore.Mvc;
using Practice_Basic_MVC_Project.Models;

namespace Practice_Basic_MVC_Project.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Furkan",
                LastName = "Coşkun",
                Email = "furkancoskun@example.com"
            };
            var orders = new List<Order>()
            {
                new Order{Id = 1, ProductName = "Laptop", Price = 25000, Quantity =1},
                new Order{Id = 2, ProductName = "Phone", Price = 35000, Quantity =1},
                new Order{Id = 3, ProductName = "Webcam", Price = 1500, Quantity =1},

            };


            CustomerOrderViewModel viewModel = new CustomerOrderViewModel()
            {
                Customer = customer,
                Orders = orders
            };
            return View(viewModel);
        }
    }
}
