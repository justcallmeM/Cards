namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CardHistory", "ID", "dbo.Card");
            DropIndex("dbo.CardHistory", new[] { "ID" });
            RenameColumn(table: "dbo.CardHistory", name: "ID", newName: "card_ID");
            AlterColumn("dbo.CardHistory", "card_ID", c => c.Int());
            CreateIndex("dbo.CardHistory", "card_ID");
            AddForeignKey("dbo.CardHistory", "card_ID", "dbo.Card", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CardHistory", "card_ID", "dbo.Card");
            DropIndex("dbo.CardHistory", new[] { "card_ID" });
            AlterColumn("dbo.CardHistory", "card_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.CardHistory", name: "card_ID", newName: "ID");
            CreateIndex("dbo.CardHistory", "ID");
            AddForeignKey("dbo.CardHistory", "ID", "dbo.Card", "ID", cascadeDelete: true);
        }
    }
}
