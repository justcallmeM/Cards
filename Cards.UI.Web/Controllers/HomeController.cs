using Cards.UI.Web.DataAccessLayer;
using Cards.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cards.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        //skirta tik sitam controller'iui
        //norint vaizdui kazka paduoti reikia:
        //apsirasyti modeli
        private CardContext db = new CardContext();
        public ActionResult Index()
        {
            //modelio viduje turetu kazkas buti
            //grazinti modelio atributa.
            return View(db.Cards.ToList());
        }
    }
}