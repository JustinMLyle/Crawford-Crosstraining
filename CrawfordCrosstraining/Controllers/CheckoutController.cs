using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stripe;

namespace CrawfordCrosstraining.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            
            var stripePublishKey = ConfigurationManager.AppSettings["pk_test_rpi5cJyfJ4D97GRFXa53zXzd"];            
            ViewBag.StripePublishKey = stripePublishKey;
            StripeConfiguration.SetApiKey("sk_test_t6Sq0rtKvpxmE0oHFvihPqk3");

            return View();
        }

        public ActionResult Charge(string stripeEmail, string stripeToken)
        {
         

            var customers = new StripeCustomerService();
            var charges = new StripeChargeService();

            var customer = customers.Create(new StripeCustomerCreateOptions
            {
                
                Email = stripeEmail,
                SourceToken = stripeToken
            });

            var charge = charges.Create(new StripeChargeCreateOptions
            {
                Amount = 500,//charge in cents
                Description = "Sample Charge",
                Currency = "usd",
                CustomerId = customer.Id
            });

            // further application specific code goes here

            return View();
        }
    }
}