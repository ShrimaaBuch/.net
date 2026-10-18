using System.Collections.Generic;
using System.Web.Mvc;
using Practical_7.Models;

namespace Practical_7.Controllers
{
    public class FeedbackController : Controller
    {
        
        private static List<Feedback> feedbackList = new List<Feedback>();

      
        public ActionResult Index()
        {
            return View();
        }

      
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

     
        public ActionResult List()
        {
            return View(feedbackList);
        }

        // HTTP POST - Create
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            feedbackList.Add(feedback);

            return RedirectToAction("List");
        }
    }
}