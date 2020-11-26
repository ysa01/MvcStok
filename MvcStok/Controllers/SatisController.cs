
using MvcStok.DAL;
using MvcStok.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MvcStok.Controllers
{
    public class SatisController : BaseController
    {

        // GET: Satis
      public ActionResult Index()
        {
            return View(service.salesRepository.GetAll());
        }
        
        [HttpGet]
        public ActionResult YeniSatis()
        {
            ViewBag.Categories = service.categoryRepository.GetAll();
            ViewBag.Product = service.productRepository.GetAll();
            ViewBag.Customer = service.customerRepository.GetAll();
            return View();//sayfa model tanımladıgında modeli newlemek gerekir
        }
        [HttpPost]
        public ActionResult YeniSatis(SalesVM p1)
        {
            TBLSATISLAR sat = new TBLSATISLAR()
            {
               
                KATEGORI=p1.CategoryID,
                URUN = p1.ProductID,
                MUSTERI = p1.CustomerID,
                FIYAT = p1.price,
                ADET = (byte)p1.ProductPiece,

            };
            service.salesRepository.Insert(sat);
         var urun=   service.productRepository.Find((int)sat.URUN);
            urun.STOK =Convert.ToByte(Convert.ToInt32(urun.STOK) - Convert.ToInt32(sat.ADET));
            service.productRepository.Guncelle(urun);

            return RedirectToAction("Index","Urun");
        }

        
        public ActionResult GetProductList(int categoryId)
        {
            var bul = service.productRepository.GetAll();
            bul = bul.FindAll(x => x.URUNKATEGORI == categoryId);
           var result= bul.Select(x => new { Id = x.URUNID, Name = x.URUNADI }).ToList();
            return Json(result,JsonRequestBehavior.AllowGet);
        }

    }
}