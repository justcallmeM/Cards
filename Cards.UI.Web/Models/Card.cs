using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cards.UI.Web.Models
{
    public enum State
    {
        Registered, Active, Blocked, Expired
    }
    public class Card
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Unique Number")]
        public string number { get; set; }

        [Display(Name = "State")]
        public State state { get; set; }

        [Display(Name = "Expiration Date")]
        [DateValidate]
        public DateTime expirationDate { get; set; }

        public virtual ICollection<CardHistory> CardHistories { get; set; }
    }

    public class CardViewModel
    {
        public int ID { get; set; }

        public string number { get; set; }

        public State state { get; set; }

        public DateTime expirationDate { get; set; }

        public string niceDate { get { return this.expirationDate.ToString("yyyy-MM-dd"); } }

        public CardViewModel()
        {

        }
    }

}