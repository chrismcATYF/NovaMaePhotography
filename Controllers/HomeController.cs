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

        [Authorize]
        [Route("PersonalGallery", Name = "PersonalGalleryPage")]
        public ActionResult PersonalGallery()
        {
            return View();
        }

        [Route("Book", Name = "BookPage")]
        public ActionResult Book()
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