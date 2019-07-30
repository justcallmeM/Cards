using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

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