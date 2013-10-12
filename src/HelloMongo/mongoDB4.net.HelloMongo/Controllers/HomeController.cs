using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using config = System.Configuration.ConfigurationManager;
using mongoDB4.net.HelloMongo.Models;
using mongoDB4.net.HelloMongo.Repositories;

namespace mongoDB4.net.HelloMongo.Controllers
{
    public class HomeController : Controller
    {
        private CommentsRepository _commentsRepository;

        public HomeController()
        {
            _commentsRepository = new CommentsRepository(config.ConnectionStrings["mongo"].ConnectionString);
        }

        [HttpGet]
        public ActionResult Index()
        {   
            return View();
        }

        [HttpPost]
        public ActionResult Index(Comment comment)
        {
            _commentsRepository.Save(comment);
            return RedirectToAction("Results");
        }

        public ActionResult Results()
        {
            ViewData.Model = _commentsRepository.GetAll();
            return View();
        }
    }
}
