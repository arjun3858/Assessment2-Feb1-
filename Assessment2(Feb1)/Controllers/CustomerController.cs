using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assessment2_Feb1_.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.msg = "Welcome to Customer Page";
            return View();
        }
        public ActionResult CustomerList()
        {
            List<string> list = new List<string>()
            {
                "Rajesh",
                "Naveen",
                "Arun",
                "Sawanth",
                "Ashwin",
            };
            ViewBag.nameList = list;
            return View();
        }
        public ActionResult RedirectDemo()
        {

            TempData["WelcomeMessage"] = "Welcome to the Redirect Demo!";
            return RedirectToAction("DisplayMessage");
        }
        public ActionResult DisplayMessage()
        {
            // Retrieve TempData message
            string welcomeMessage = TempData["WelcomeMessage"] as string;

            // Check if message exists
            if (!string.IsNullOrEmpty(welcomeMessage))
            {
                // Display the message in the view
                ViewBag.Message = welcomeMessage;

                // Clear TempData after being read
                TempData.Clear();
            }
            else
            {
                ViewBag.Message = "No welcome message available.";
            }
            return View();
        }
    }
}