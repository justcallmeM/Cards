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

namespace Cards.UI.Web.Controllers
{
    public class CardController : Controller
    {
        private CardContext db = new CardContext();

        // GET: Card
        public ActionResult Index()
        {
            return View(db.Cards.ToList());
        }

        public ActionResult ReadDatabase([DataSourceRequest] DataSourceRequest request)
        {
            List<Card> card = db.Set<Card>().ToList();

            var result = card.Select(x => new Card
            {
                ID = x.ID,
                number = x.number,
                state = x.state,
                expirationDate = x.expirationDate
            });

            return Json(result.ToDataSourceResult(request));
        }

        [HttpGet, ActionName("Details")]
        public ActionResult Details(int? id)
        {
            Card card = db.Cards.Find(id);
            CardHistory cardHistory = new CardHistory();

            cardHistory.acquisitionDate = DateTime.Now;
            cardHistory.stateChangeDate = DateTime.Now;
            cardHistory.card = card;

            /*pakeisti sita "IF" i WCF*/
            if (card.expirationDate < DateTime.Now)
            {
                card.state = State.Expired;
                
                db.SaveChanges();
            }

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
                    card.state = State.Active;
                    cardHistory.state = State.Active;
                    db.CardHistories.Add(cardHistory);
                    db.SaveChanges();
                    break;
                case 3:
                    break;
                default:
                    break;
            }

            return RedirectToAction("Index");
        }

        // POST: Card/Create
        [HttpGet]
        public ActionResult Create([Bind(Include = "ID,number,state,expirationDate")] Card card)
        {
            Random rnd = new Random();

            string randomNumber = "";
            for(int  i = 0; i < 19; i++)
            {
                randomNumber += rnd.Next(0, 9).ToString();
            }

            var model = new Card()
            {
                
                number = randomNumber,
                state = State.Registered,
                expirationDate = DateTime.Now.AddYears(10)
                
            };

            if (ModelState.IsValid)
            {
                
                db.Cards.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(card);
        }

        // GET: Card/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Card card = db.Cards.Find(id);
            if (card == null)
            {
                return HttpNotFound();
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

        // GET: Card/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Card card = db.Cards.Find(id);
            if (card == null)
            {
                return HttpNotFound();
            }
            return View(card);
        }

        // POST: Card/Delete/5
        [HttpGet, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Card card = db.Cards.Find(id);
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
