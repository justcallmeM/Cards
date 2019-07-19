namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingTables10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CardHistory", "state", c => c.Int(nullable: false));
            AlterColumn("dbo.CardHistory", "acquisitionDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CardHistory", "stateChangeDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Card", "number", c => c.String());
            AlterColumn("dbo.Card", "state", c => c.Int(nullable: false));
            AlterColumn("dbo.Card", "expirationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Card", "expirationDate", c => c.DateTime());
            AlterColumn("dbo.Card", "state", c => c.Int());
            AlterColumn("dbo.Card", "number", c => c.Int());
            AlterColumn("dbo.CardHistory", "stateChangeDate", c => c.DateTime());
            AlterColumn("dbo.CardHistory", "acquisitionDate", c => c.DateTime());
            AlterColumn("dbo.CardHistory", "state", c => c.Int());
        }
    }
}
