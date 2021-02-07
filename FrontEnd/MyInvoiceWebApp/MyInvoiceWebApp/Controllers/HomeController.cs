using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyInvoiceWebApp.Helpers;
using MyInvoiceWebApp.Models;
using Newtonsoft.Json;


namespace MyInvoiceWebApp.Controllers
{
    public class HomeController : Controller
    {
        InvoiceAPI _api = new InvoiceAPI();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //public async Task<IActionResult> Index()
        //{
        //    List<Book> book = new List<Book>();

        //    HttpClientHandler clientHandler = new HttpClientHandler();
        //    clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

        //    // Pass the handler to httpclient(from you are calling api)
        //    //HttpClient client = new HttpClient(clientHandler);
        //    HttpClient client = new HttpClient();
        //    client = _api.Initial();

        //    HttpResponseMessage res = await client.GetAsync("api/Books");

        //    if (res.IsSuccessStatusCode)
        //    {
        //        var result = res.Content.ReadAsStringAsync().Result;
        //        book = JsonConvert.DeserializeObject<List<Book>>(result);
        //        JsonConvert.DeserializeObject
        //    }

        //    return View(book);
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
