using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyInvoiceWebApp.Helpers
{
    public class InvoiceAPI
    {
        public  HttpClient Initial()
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:44389/");
            return Client;
        }
    }
}
