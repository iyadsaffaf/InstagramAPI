using InstagramAPI.Models;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace InstagramAPI.Controllers
{
    public class HomeController : Controller
    {   
        //get home/index
        public ActionResult Index()
        {
            return View();
        }


        //get home/Csharp
        // Action method
        public ActionResult CSharp()
        {
            ViewBag.Message = "Haal de feed met behulp van C#";

            return View(GetDataFromJSon());
        }
        //get home/JavaScript
        public ActionResult JavaScript()
        {
            ViewBag.Message = "Haal de feed met behulp van JavaScript";

            return View();
        }

        // Haal de data van url van json en zit deze in String variable
        [NonAction]
        public String ReadJson()
        {

            var json = "";
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://api.instagram.com/v1/users/self/?access_token=13568275929.28a7bf6.acabc60f23064130ad30475e811cd6db");
            }
            return json;


        }

        //Krijg de  data van json bestand
        [NonAction]
        public InstagramUser GetDataFromJSon()
        {   
            InstagramUser data = JsonConvert.DeserializeObject<InstagramUser>(ReadJson());

            return data;


        }


        // Deze functie is verantwoordelijk om een post request te uitvoeren en de response van deze functie is de id code.
        

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Action()
        {    //Haal de data van ConfigurationManager bestand die kun je vinden bij web.config
            var client_id = ConfigurationManager.AppSettings["instagram.clientid"].ToString();
            var redirect_uri = ConfigurationManager.AppSettings["instagram.redirecturi"].ToString();
            Response.Redirect("https://api.instagram.com/oauth/authorize/?client_id=" + client_id + "&redirect_uri=" + redirect_uri + "&response_type=code");
            //redirect to het zelfde pagina
            return RedirectToAction("Index");


        }
        // Deze functie is verantwoordelijk om een post request te uitvoeren en de response van deze functie is de token 
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Token()
        {   //Haal de data van ConfigurationManager bestand die kun je vinden bij web.config
            var client_id = ConfigurationManager.AppSettings["instagram.clientid"].ToString();
            var redirect_uri = ConfigurationManager.AppSettings["instagram.redirecturi"].ToString();
            // redirect 
            Response.Redirect("https://api.instagram.com/oauth/authorize/?client_id=" + client_id + "&redirect_uri=" + redirect_uri + "&response_type=token");
            //redirect to het zelfde pagina
            return RedirectToAction("Index");


        }
    }
}