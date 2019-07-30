using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Cards.UI.Web;
using Cards.UI.Web.DataAccessLayer;
using Cards.UI.Web.Models;

namespace Jobs
{
    public class CheckExpiration : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            //JobKey key = context.JobDetail.Key; //indicates the identity of the job that should be executed when the trigger fires.
            //JobDataMap dataMap = context.MergedJobDataMap;
            //await Console.Out.WriteLineAsync("Instance " + key + " of DumbJob says: " + dataMap.Values.ElementAt(0) + ", and val is: " + dataMap.Values.ElementAt(1));

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
