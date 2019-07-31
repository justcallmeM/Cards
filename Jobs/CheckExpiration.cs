using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cards.UI.Web.DataAccessLayer;
using Cards.UI.Web.Models;

namespace Jobs
{
    public class CheckExpiration : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            CardContext db = new CardContext();

            List<Card> cards = db.Set<Card>().Where(card => card.expirationDate <= DateTime.Now && card.state != State.Expired).ToList();

            foreach (Card card in cards)
            {
                CardHistory cardHistory = new CardHistory();

                card.state = State.Expired;

                cardHistory.acquisitionDate = DateTime.Now;
                cardHistory.stateChangeDate = DateTime.Now;
                cardHistory.card = card;
                db.CardHistories.Add(cardHistory);
            }
            db.SaveChanges();
        }
    }
}
