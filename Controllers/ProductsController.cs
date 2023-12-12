using SelfHostServer.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Controllers
{
    internal class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id=1, Title="Product 1"},
            new Product{Id=2, Title="Product 2"},
            new Product{Id=3, Title="Product 3"},
            new Product{Id=4, Title="Product 4"}
        };
        [HttpGet]
        public IEnumerable<Product> All()
        {
            return products;
        }
    }
}
