using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment_5_Coffee_Shop.Models;

namespace Assessment_5_Coffee_Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Order()
        {
            ViewBag.Message = "Order Confirmation";

            return View();
        }

        public ActionResult AboutUS()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OrderDone()
        {



            return View();
        }

        public ActionResult Menu()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Receipt(string name, char size1, char size2, double dragon, double freezie, double burger, double fries)
        {

            Order here = new Order()
            {
                Name = name,
                DrinkSize1 = size1,
                DrinkSize2 = size2,
                Dragon = dragon,
                Freezie = freezie,
                Burger = burger,
                Fries = fries
            };

            return View(here);
        }
                
        [HttpPost]
        public ActionResult Save(string firstname, string lastname, string emailaddress, string password, int phone)
        {

            WebUser user = new WebUser()
            {
                FirstName = firstname,
                LastName = lastname,
                //If username is in db, respond this is already taken.
                Email = emailaddress,
                //If email is in db, respond this is already taken.
                Password = password,
                Phone = phone

                //If !exist records, save this to db. 

            };

            return View(user);
        }






    }
}
