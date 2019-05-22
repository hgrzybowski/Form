using Formularz.Config;
using Formularz.Models;
using Formularz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formularz.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            PostRepository postRepository = new PostRepository();
            var getPost = postRepository.Get();
            //var result = query.Get();

            //var getPostEntiti = query.Get(1);
            return View(getPost);
        }

        [HttpPost]
        public ActionResult Register(User register)
        {
            ;
            return View();
        }
        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            PostRepository postRepository = new PostRepository();
            postRepository.Create(post);
            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public ActionResult GetRegister()
        //{
        //    return View();
        //}
    }
}