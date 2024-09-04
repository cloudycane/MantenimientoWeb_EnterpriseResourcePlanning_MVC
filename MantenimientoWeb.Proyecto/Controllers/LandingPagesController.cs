using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MantenimientoWeb.Proyecto.Controllers
{
    public class LandingPagesController : Controller
    {
        // GET: LandingPagesController
        public ActionResult UILandingEmpresa()
        {
            return View();
        }

        public ActionResult UILandingCompra()
        {
            return View();
        }

        public ActionResult UILandingBuscar()
        {
            return View();
        }
       
        public ActionResult UILandingProduccion()
        {
            return View();
        }
        public ActionResult UILandingAlmacen()
        {
            return View();
        }
    }
}
