using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
                                                 //IProductServiceyi çağırıyoruz
        private IProductService _productService; //IProductDal'ı IProductServices implementosunu yapan ProductManager içerisine IProductDal' inject ettik.
                                                 //IProductDal ile ilgilenen iş katmanı. Şuan arayüz katmanındayız bi işimiz yok
        public HomeController(IProductService productService)
        {
            _productService = productService;    //Şuan sadece IProductServices tanımlı.
                                                 //IProductServices'i çağırdığımız da zaten IProductManager gelicek(Startup.cs 30.satır).
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
