using MvcStok.BLL.Repository.Service;
using System.Web.Mvc;

namespace MvcStok.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected EntityService service = new EntityService();
        public ActionResult HelpIndex()
        {
            return View();
        }
    }
}