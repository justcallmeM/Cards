using Cards.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cards.UI.Web.DataAccessLayer
{
    public class CardInitializer : System.Data.Entity.CreateDatabaseIfNotExists<CardContext>
    {
        //The Seed method takes the database context object as an input parameter, and the code in the method uses that object to add new entities to the database. 
        //kodel protected override?
        protected override void Seed(CardContext context)
        {
            var cards = new List<Card>
            {
                /*CardHistories = new List<CardHistory> { new CardHistory() { } }*/
                new Card{ID = 1, state=State.Registered, expirationDate=DateTime.Parse("2020-05-12"), number="1234145874851236458"},
                new Card{ID = 2, state=State.Active,     expirationDate=DateTime.Parse("2025-11-15"), number="1594124812591981491"},
                new Card{ID = 3, state=State.Blocked,    expirationDate=DateTime.Parse("2030-12-17"), number="5619549719819819811"},
                new Card{ID = 5, state=State.Registered, expirationDate=DateTime.Parse("2021-12-06"), number="1981987954565498423"},
                new Card{ID = 4, state=State.Active,     expirationDate=DateTime.Parse("2020-03-07"), number="8561191961332313132"},
                new Card{ID = 6, state=State.Active,     expirationDate=DateTime.Parse("2022-06-25"), number="8984987984654985561"},
                new Card{ID = 7, state=State.Active,     expirationDate=DateTime.Parse("2027-07-24"), number="1165198491256132416"},
                new Card{ID = 8, state=State.Blocked,    expirationDate=DateTime.Parse("2026-07-10"), number="9884979845615681113"},
                new Card{ID = 9, state=State.Active,     expirationDate=DateTime.Parse("2024-01-01"), number="1648978654132156651"},
                new Card{ID = 10, state=State.Registered, expirationDate=DateTime.Parse("2020-04-06"), number="7872215649198489498"}
            };
            cards.ForEach(c => context.Cards.Add(c));
            context.SaveChanges();

            /*var cardHistories = new List<CardHistory>
            {
                new CardHistory{cardHistoryID = 1, acquisitionDate=DateTime.Parse("2019-12-12"), state=State.Registered, stateChangeDate=DateTime.Parse("2019-12-12")},
                new CardHistory{cardHistoryID = 2, acquisitionDate=DateTime.Parse("2019-12-12"), state=State.Blocked, stateChangeDate=DateTime.Parse("2019-12-19")}
            };

            cardHistories.ForEach(ch => context.CardHistories.Add(ch));
            context.SaveChanges();*/
        }


    }
}