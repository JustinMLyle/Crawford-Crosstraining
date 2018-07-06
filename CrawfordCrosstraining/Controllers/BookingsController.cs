using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CrawfordCrosstraining.Models;
using RestSharp;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace CrawfordCrosstraining.Controllers
{
    public class BookingsController : Controller
    {



        public void CreateCalendlyWebhookSubscription()
        {
            var task = PostCreateWebhookSubscription();
            task.Wait();
            var response = task.Result;
            var body = response.Content.ReadAsStringAsync().Result;
        }

        private static async Task<HttpResponseMessage> PostCreateWebhookSubscription()
        {
            var client = new HttpClient { BaseAddress = new Uri("https://calendly.com") };
            var request = new HttpRequestMessage(HttpMethod.Post, "/api/v1/hooks/");
            var keyValues = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("url"," http://localhost:56176/Bookings/Index.html"),
            new KeyValuePair<string, string>("events[]","invitee.created"),
            new KeyValuePair<string, string>("events[]","invitee.canceled")
        };
            request.Content = new FormUrlEncodedContent(keyValues);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded") { CharSet = "UTF-8" };
            request.Content.Headers.Add("X-TOKEN", "GONIOOMIHJJVJ2VWJBIBMUEMI5PEWHWA");
            return await client.SendAsync(request);
        }

        public ActionResult Index()
        {

            
            return View();
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        //public ActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
