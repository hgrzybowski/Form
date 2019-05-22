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
    public class CommentController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            CommentRepository commentRepository = new CommentRepository();
            var getComment = commentRepository.Get();
            //var result = query.Get();

            //var getPostEntiti = query.Get(1);
            return View(getComment);
        }

        [HttpPost]
        public ActionResult Register(User register)
        {
            ;
            return View();
        }
        [HttpGet]
        public ActionResult Comment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Comment comment)
        {
            CommentRepository commentRepository = new CommentRepository();
            commentRepository.Create(comment);
            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public ActionResult GetRegister()
        //{
        //    return View();
        //}
    }
}