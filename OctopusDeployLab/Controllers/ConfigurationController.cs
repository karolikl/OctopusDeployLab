using System.Web.Mvc;

namespace OctopusDeployLab.Controllers
{
    public class ConfigurationController : Controller
    {
        public ActionResult Environments()
        {
            return View();
        }

        public ActionResult Machine()
        {
            return View();
        }

        public ActionResult Project()
        {
            return View();
        }

        public ActionResult Package()
        {
            return View();
        }
    }
}