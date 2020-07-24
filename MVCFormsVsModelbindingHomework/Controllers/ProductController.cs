using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCFormsVsModelbindingHomework.Models;

namespace MVCFormsVsModelbindingHomework.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(IFormCollection form)
        {
            Product prod = new Product();
            prod.Name = form["name"];
            prod.Description = form["description"];

            ViewData["Added"] = prod.Name;

            return View();
        }

        [HttpGet]
        public IActionResult AddProductWithBinding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProductWithBinding(Product p)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = $"{p.Name} was added";
                //Add to Database Here...
            }
            return View();
        }
    }
}
