using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyInvoiceWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyInvoiceWebApp.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Insert(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert()
        {
            return View();
        }

    }
}