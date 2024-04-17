using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Razor_View_Engine.Models;

namespace MVC_Razor_View_Engine.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult GetHF()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult DispalyCustomer()
        {
            // Work Just in Controller (Action To Action) . 
            // TempData :: ==> (Param) [Key] || [Value] .
            // quand tu peut le faire l'appel en utilise ViewBeg.[Key] . 
            TempData["Msg"] = "Template Data Passing Paramers . To Action Search . using Action Link In (View) DisplayCustomer . ";

            var cust = new Customer(1, "soufiane el marnissi", "10 rue oued ed_dahab hay el filaha", 23, "0608800058");
            return View(cust);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer cust)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("DispalyCustomer");
            }
            return View(cust);
        }

        public ActionResult Search()
        {
            ViewBag.Msg = TempData["Msg"];
            TempData.Keep("Msg");
            return View();
        }

        [HttpPost]
        public ActionResult Search(string name)
        {
            List<Customer> lst = new List<Customer>()
            {
                new Customer{Id = 1, Name = "tarik", Adresse= "france", Age = 30, Tele= "0606060606"},
                new Customer{Id = 2, Name = "ziad", Adresse= "france paris", Age = 26, Tele= "0605050505"},
                new Customer{Id = 3, Name = "hanae", Adresse= "fes", Age = 30, Tele= "0604040404"},
                new Customer{Id = 4, Name = "ftah", Adresse= "tinghir", Age = 21, Tele= "0603030303"}
            };

            var cust = lst.Find(a => a.Name == name);

            if(cust != null)
            {
                // Pour Passe les Info a la view . 
                ViewBag.Result = "Search Result For : " + name;
                // View Data Exemple : 
                ViewData["key"] = true;
            }
            else
            {
                ViewBag.Result = "Not Found . ";
                ViewData["key"] = false;
            }

            return View(cust);
        }
    }
}