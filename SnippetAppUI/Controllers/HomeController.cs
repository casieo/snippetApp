using SnippetApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SnippetAppUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSnippet(FormCollection collection)
        {

            var query = collection["Txtquery"];
          
            {
                var snippets = Helper.SearchForSnippets(query);
                return View(snippets);
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Snippet snippet)
        {
            var newSnippet = Helper.CreateKb(snippet.Text, snippet.PageorLocation);
            if (newSnippet != null)
            {
                return RedirectToAction("Detail",new {id = newSnippet.TextID});
            }
            return View();
        }

   
        [HttpGet]
        public ActionResult Edit(int id)
        {            
                var snippet = Helper.GetSnippetByID(id);
                return View(snippet);            
        }

        [HttpPost]
        public ActionResult PostEdit(Snippet snippet)
        {
            var newSnippet = Helper.EditKb(snippet.Text, snippet.PageorLocation);
            return View();
       }


        public ActionResult Detail(int id)
        {
            var snippet = Helper.GetSnippetByID(id);
            return View(snippet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}