using Cards.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Cards.UI.Web.DataAccessLayer
{
    public class CardContext : DbContext
    {
        public CardContext() : base("CardContext")
        {
        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardHistory> CardHistories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //prevents table names from being pluralized.
            /*The generated tables in the database would be named Students, Courses, and Enrollments. Instead, the table 
             * names will be Student, Course, and Enrollment. Developers disagree about whether table names 
             * should be pluralized or not. This tutorial uses the singular form, but the important point is 
             * that you can select whichever form you prefer by including or omitting this line of code.*/
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}