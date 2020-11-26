using MvcStok.DAL;
using MvcStok.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcStok.Controllers
{
    public class UrunController : BaseController
    {
        // GET: Urun

        public ActionResult Index()
        {
            var urnveriler = service.productRepository.GetAll();
            return View(urnveriler);
        }
        
        public ActionResult UrunEkle()
        {
            //List<SelectListItem> degerler = (from i in service.categoryRepository.GetAll()
            //                                 select new SelectListItem
            //                                 {
            //                                     Text = i.KATEGORIAD,
            //                                     Value = i.KATEGORIID.ToString()
            //                                 }).ToList();
            //ViewBag.dgr = degerler;
            return View(service.categoryRepository.GetAll());

        }
        [HttpPost]
        public ActionResult UrunEkle(ProductVM pro)
        {
            TBLURUNLER p1 = new TBLURUNLER()
            {
                URUNADI = pro.ProductName,
                URUNKATEGORI = (short)pro.ProductCategory,
                FIYAT = pro.ProductPrice,
                STOK = (byte)pro.ProductStock,
                MARKA = pro.ProductBrand,

            };
            service.productRepository.Insert(p1);
            return RedirectToAction("Index");

        }
        public ActionResult Sil(int id)
        {
            var urun = service.productRepository.Find(id);
            service.productRepository.Delete(urun);
            service.productRepository.Save();
            return RedirectToAction("Index");

        }
        public ActionResult UrunGetir(int? ID)
        {
            if(ID!=null)
            {
                var urn = service.productRepository.Find((int)ID);
                ViewBag.Categories = service.categoryRepository.GetAll();
                return View(urn);
            }
            else
            {
                return Redirect("Index");
            }
        }

        public ActionResult Guncelle(ProductVM urn)
        {
            TBLURUNLER p1 = new TBLURUNLER()
            {
                URUNID = urn.ID,
                URUNKATEGORI = (short)urn.ProductCategory,
                URUNADI = (string)urn.ProductName,
                MARKA = urn.ProductBrand,
                FIYAT = urn.ProductPrice,
                STOK = (byte)urn.ProductStock
            };
            service.productRepository.Guncelle(p1);
            return Redirect("Index");

        }
    }

}