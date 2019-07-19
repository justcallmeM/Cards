namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CardHistory", "card_ID", "dbo.Card");
            DropIndex("dbo.CardHistory", new[] { "card_ID" });
            DropPrimaryKey("dbo.Card");
            AddColumn("dbo.Card", "cardNR", c => c.Long(nullable: false));
            AlterColumn("dbo.CardHistory", "card_ID", c => c.Int());
            AlterColumn("dbo.Card", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Card", "ID");
            CreateIndex("dbo.CardHistory", "card_ID");
            AddForeignKey("dbo.CardHistory", "card_ID", "dbo.Card", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CardHistory", "card_ID", "dbo.Card");
            DropIndex("dbo.CardHistory", new[] { "card_ID" });
            DropPrimaryKey("dbo.Card");
            AlterColumn("dbo.Card", "ID", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.CardHistory", "card_ID", c => c.Long());
            DropColumn("dbo.Card", "cardNR");
            AddPrimaryKey("dbo.Card", "ID");
            CreateIndex("dbo.CardHistory", "card_ID");
            AddForeignKey("dbo.CardHistory", "card_ID", "dbo.Card", "ID");
        }
    }
}
