﻿using System.Web.Mvc;

namespace OctopusDeployLab.Controllers
{
    public class InstallationController : Controller
    {
        public new ActionResult Server()
        {
            return View();
        }

        public ActionResult Tentacle()
        {
            return View();
        }
    }
}