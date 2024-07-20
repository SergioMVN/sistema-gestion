using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class MantenedorController : Controller
    {
        // GET: Mantenedor
        public ActionResult Paginas()
        {
            return View();
        }

        public ActionResult Permisos()
        {
            return View();
        }

        public ActionResult Roles()
        {
            return View();
        }

        public ActionResult Usuarios()
        {
            return View();
        }

    }
}