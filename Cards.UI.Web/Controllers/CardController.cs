using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cards.UI.Web.DataAccessLayer;
using Cards.UI.Web.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Cards.UI.Web.ServiceReference1;
using ActivationService;

namespace Cards.UI.Web.Controllers
{
    public class CardController : Controller
    {
        private CardContext db = new CardContext();

        public ActionResult Index()
        {
            return View(db.Cards.ToList());
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult ReadDatabase([DataSourceRequest] DataSourceRequest request)
        {

            List<Card> card = db.Set<Card>().ToList();

            var result = card.Select(x => new CardTestas
            {
                ID = x.ID,
                number = x.number,
                state = x.state,
                expirationDate = x.expirationDate
            });

            return Json(result.ToDataSourceResult(request));
        }

        [HttpGet, ActionName("Block")]
        public ActionResult Block(int? id)
        {
            Card card = db.Cards.Find(id);
            CardHistory cardHistory = new CardHistory();

            cardHistory.acquisitionDate = DateTime.Now;
            cardHistory.stateChangeDate = DateTime.Now;
            cardHistory.card = card;
            if(card == null)
            {
                return RedirectToAction("Error");
            }
            if (card.state == State.Registered || card.state == State.Active)
            {
                switch ((int)card.state)
                {
                    case 0:
                        card.state = State.Blocked;
                        cardHistory.state = State.Blocked;
                        db.CardHistories.Add(cardHistory);
                        db.SaveChanges();
                        break;
                    case 1:
                        card.state = State.Blocked;
                        cardHistory.state = State.Blocked;
                        db.CardHistories.Add(cardHistory);
                        db.SaveChanges();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }
            else
            { }

            return RedirectToAction("Index");
        }

        [HttpGet, ActionName("Unblock")]
        public ActionResult Unblock(int? id)
        {
            Card card = db.Cards.Find(id);
            CardHistory cardHistory = new CardHistory();

            cardHistory.acquisitionDate = DateTime.Now;
            cardHistory.stateChangeDate = DateTime.Now;
            cardHistory.card = card;

            if (card == null)
            {
                return RedirectToAction("Error");
            }
            if (card.state == State.Blocked)
            {
                card.state = State.Active;
                cardHistory.state = State.Active;
                db.CardHistories.Add(cardHistory);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        // POST: Card/Create
        [HttpGet]
        public ActionResult Create([Bind(Include = "ID,number,state,expirationDate")] Card card)
        {
            //service1 
            ServiceReference2.Service1Client service1Client1 = new ServiceReference2.Service1Client();

            Random rnd = new Random();
            string randomNumber = "";
            for (int i = 0; i < 19; i++)
            {
                randomNumber += rnd.Next(0, 9).ToString();
            }
            var cardModel = new Card()
            {
                number = randomNumber,
                state = State.Registered,
                expirationDate = DateTime.Now.AddYears(10)

            };

            var cardHistoryModel = new CardHistory()
            {
                state = State.Registered,
                acquisitionDate = DateTime.Now,
                stateChangeDate = DateTime.Now,
                card = cardModel
            };

            //if (ModelState.IsValid)
            //{
                db.Cards.Add(cardModel);
                db.CardHistories.Add(cardHistoryModel);
                db.SaveChanges();                    
            //}

            //maybe do the call of the service method here?
            //service1.GetStringData(randomNumber);
            service1Client1.GetStringData(randomNumber);

            return RedirectToAction("Index");
        }

        // GET: Card/Edit/
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }

            Card card = db.Cards.Find(id);

            if (card == null)
            {
                return RedirectToAction("Error");
            }

            return View(card);
        }
        // POST: Card/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,number,state,expirationDate")] Card card)
        {
            if (ModelState.IsValid)
            {
                db.Entry(card).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(card);
        }

        // GET: Card/History/
        public ActionResult History(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }
            
            CardHistory cardHistories = db.CardHistories.Where(x => x.card.ID == id).FirstOrDefault();
            Card card = db.Cards.Where(x => x.ID == id).FirstOrDefault();

            if (card == null)
            {
                return RedirectToAction("Error");
            }
            return View(card);
        }
        // POST: Card/History/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult History([Bind(Include = "cardHistoryID, state, acquisitionDate, stateChangeDate, card")] CardHistory cardHistory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cardHistory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cardHistory);
        }

        // GET: Card/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }
            Card card = db.Cards.Find(id);
            if (card == null)
            {
                return RedirectToAction("Error");
            }
            return View(card);
        }

        // POST: Card/Delete/5
        [HttpGet, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Card card = db.Cards.Find(id);

            if(card == null)
            {
                return RedirectToAction("Error");
            }
            card.CardHistories.ToList().Each(e =>
            {
                db.CardHistories.Remove(e);
            });    

            db.Cards.Remove(card);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
