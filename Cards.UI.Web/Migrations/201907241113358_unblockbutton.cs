namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unblockbutton : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Card", "unblockButton", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Card", "unblockButton");
        }
    }
}
