using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public class AngularController : Controller
    {
        private readonly IProductService _productService;

        public AngularController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Home
        public ActionResult Index()
        {
            var products = _productService.GetProducts().Take(2);
            return View();
            //return Json(products, JsonRequestBehavior.AllowGet);
        }

        public ActionResult HopmePageProducts()
        {
            var products = _productService.GetProducts().Take(2);
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ProductDetails(string id)
        {
            var product = _productService.GetByUrl(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return Json(product, JsonRequestBehavior.AllowGet);
        }
    }
}
