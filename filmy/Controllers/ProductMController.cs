using filmy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sklep.MVC.Controllers
{
    public class ProductMController : Controller
    {     private static IList<ProductM> Products = new List< ProductM > /*Tworzymy nową liste którą przkazujemy do ActionResult*/
        {
            new ProductM(){ProductId = 1, ProductName = "Gryzak", ProductDescription = "Powierzchnia gryzaczka pokryta jest wypukłą teksturą, która masuje obolałe dziąsła i w ten sposób niweluje dyskomfort i zapewnia ulgę.", ProductPrice = 33},
            new ProductM(){ProductId = 2, ProductName = "Smoczek", ProductDescription = "nie zaburza odruchu ssania zapobiega odruchowi zagryzania smoczka zapewnia swobodne oddychanie i połykanie śliny nie zaburza prawidłowego rozwoju mowy i zgryzu.", ProductPrice = 34}
        };
    
        // GET: ProductMController
        public ActionResult Index()
        {
            return View(Products);
        }

        // GET: ProductMController/Details/5
        public ActionResult Details(int id)
        {
            return View(Products.FirstOrDefault(x=>x.ProductId==id));
            
        }

        // GET: ProductMController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductMController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductM product)
        {
           product.ProductId = Products.Count + 1;
            Products.Add(product);
            return RedirectToAction();
        }

        // GET: ProductMController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Products.FirstOrDefault(x=>x.ProductId==id));
        }

        // POST: ProductMController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductM product)
        {
            ProductM product1=Products.FirstOrDefault(x=>x.ProductId==id);
            product1.ProductName=product.ProductName;
            product1.ProductDescription=product.ProductDescription;
            product1.ProductPrice = product.ProductPrice;
            return RedirectToAction();
        }

        // GET: ProductMController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Products.FirstOrDefault(x=>x.ProductId==id));
        }

        // POST: ProductMController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductM product)
        {
            Products.Remove(Products.FirstOrDefault(x => x.ProductId == id));
            return RedirectToAction();
        }
    }
}
