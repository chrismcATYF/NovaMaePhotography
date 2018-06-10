using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NovaMaePhotography.Controllers
{
    [RoutePrefix("Home")]
    [AllowAnonymous]
    public class HomeController : Controller
    {
        [Route("", Name = "IndexPage")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("About", Name = "AboutPage")]
        public ActionResult About()
        {
            return View();
        }

        [Route("Contact", Name = "ContactPage")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("Gallery", Name = "GalleryPage")]
        public ActionResult Gallery()
        {
            return View();
        }
    }
}