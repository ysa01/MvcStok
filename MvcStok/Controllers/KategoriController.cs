using MvcStok.DAL;
using MvcStok.Models;
using System.Web.Mvc;

namespace MvcStok.Controllers
{
    public class KategoriController : BaseController
    {

        // GET: Kategori
        public ActionResult Index()
        {

            return View(service.categoryRepository.GetAll());
        }

        public ActionResult YeniKategori()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKategori(CategoryVM cat)
        {
            TBLKATEGORILER p1 = new TBLKATEGORILER()
            {
                KATEGORIAD = cat.CategoryName,

            };
            service.categoryRepository.Insert(p1);

            return Redirect("Index");

        }
        public ActionResult Sil(int id)
        {
            var kategori = service.categoryRepository.Find(id);
            service.categoryRepository.Delete(kategori);
            service.categoryRepository.Save();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int? ID)
        {
            if(ID!=null)
            {
                var ktgr = service.categoryRepository.Find((int)ID);
                return View(ktgr);
            }
            else
            {
                return Redirect("Index");
            }
          
        }
        [HttpPost]
        public ActionResult Guncelle(CategoryVM cat)
        {
            TBLKATEGORILER p1 = new TBLKATEGORILER()
            {
                KATEGORIID = cat.ID,
                KATEGORIAD=cat.CategoryName,
            };

            service.categoryRepository.CategoryUpdate(p1);
            return RedirectToAction("Index");

        }
    }
}