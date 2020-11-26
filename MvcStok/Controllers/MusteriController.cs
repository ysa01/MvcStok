using MvcStok.DAL;
using MvcStok.Models;
using System.Web.Mvc;

namespace MvcStok.Controllers
{
    public class MusteriController : BaseController
    {
        // GET: Musteri

        public ActionResult Index()
        {
            //var degerler=from d in db select d;
            //if (!string.IsNullOrEmpty(p1))
            //{
            //    degerler = degerler.Where(m => m.MUSTERIADI.Contains(p1));
            //}
            //return View(degerler.ToList());
            var musteriveri = service.customerRepository.GetAll();
            return View(musteriveri);
        }
        
        public ActionResult YeniMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri(CustomerVM cus)
        {
            TBLMUSTERILER p1 = new TBLMUSTERILER()
            {
                MUSTERIADI = cus.CustomerName,
                MUSTERISOYADI = cus.CustomerSurName,
            };
            service.customerRepository.Insert(p1);
            return RedirectToAction("Index");

        }
        public ActionResult Sil(int? ID)
        {
            if(ID!=null)
            {
                var musteri = service.customerRepository.Find((int)ID);
                service.customerRepository.Delete(musteri);
                service.customerRepository.Save();
            }

            else
            {
                return Redirect("Index");
            }
            return Redirect("Index");

        }

        public ActionResult MusteriGetir(int? ID)
        {
            if (ID != null)
            {
             var bul= service.customerRepository.Find((int)ID);
                return View(bul);
               
            }

            else
            {
                return Redirect("Index");
            }
           
        }

        public ActionResult Guncelle(CustomerVM cus)
        {
            TBLMUSTERILER p1 = new TBLMUSTERILER()
            {
                MUSTERIADI = cus.CustomerName,
                MUSTERISOYADI = cus.CustomerSurName,
                MUSTERIID = cus.ID,
            };
            service.customerRepository.CustomerUpdate(p1);
            return Redirect("Index");
        }
    }
}