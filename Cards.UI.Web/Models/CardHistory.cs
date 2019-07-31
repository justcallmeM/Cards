using System;
using System.ComponentModel.DataAnnotations;

namespace Cards.UI.Web.Models
{
    public class CardHistory
    {
        [Key]
        public int cardHistoryID { get; set; } /* Primary key */

        public State state { get; set; }

        public DateTime acquisitionDate { get; set; }

        public DateTime stateChangeDate { get; set; }

        public virtual Card card { get; set; } /*foreign key of "Card" class */
    }
}