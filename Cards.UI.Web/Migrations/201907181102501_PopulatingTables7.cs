namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingTables7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CardHistory", "card_ID", "dbo.Card");
            DropPrimaryKey("dbo.CardHistory");
            DropPrimaryKey("dbo.Card");
            AlterColumn("dbo.CardHistory", "cardHistoryID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Card", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CardHistory", "cardHistoryID");
            AddPrimaryKey("dbo.Card", "ID");
            AddForeignKey("dbo.CardHistory", "card_ID", "dbo.Card", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CardHistory", "card_ID", "dbo.Card");
            DropPrimaryKey("dbo.Card");
            DropPrimaryKey("dbo.CardHistory");
            AlterColumn("dbo.Card", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.CardHistory", "cardHistoryID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Card", "ID");
            AddPrimaryKey("dbo.CardHistory", "cardHistoryID");
            AddForeignKey("dbo.CardHistory", "card_ID", "dbo.Card", "ID");
        }
    }
}
