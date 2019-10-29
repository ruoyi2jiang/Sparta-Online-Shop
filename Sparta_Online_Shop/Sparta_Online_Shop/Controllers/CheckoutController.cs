﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sparta_Online_Shop.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult Basket()
        {
            return View();
        }

        public ActionResult CheckoutError()
        {
            return View();
        }

        public ActionResult CheckoutSuccessful()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BasketPost(string Amount)
        {
            float price;
            ViewBag.Message = Amount;

            if (float.TryParse(Amount, out price))
            {
                ViewBag.Message = Amount;
                return View("Checkout");
            }

            return View("CheckoutSuccessful");
        }

        [HttpPost]
        public ActionResult PaypalPost(string orderID)
        {
            //clear basket if successful

            ViewBag.Message = orderID;

            return RedirectToAction("CheckoutSuccessful");
        }
    }
}