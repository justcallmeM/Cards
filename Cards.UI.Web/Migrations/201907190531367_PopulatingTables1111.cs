namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingTables1111 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CardHistory", "card_ID", "dbo.Card");
            DropIndex("dbo.CardHistory", new[] { "card_ID" });
            RenameColumn(table: "dbo.CardHistory", name: "card_ID", newName: "ID");
            AlterColumn("dbo.CardHistory", "ID", c => c.Int(nullable: false));
            CreateIndex("dbo.CardHistory", "ID");
            AddForeignKey("dbo.CardHistory", "ID", "dbo.Card", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CardHistory", "ID", "dbo.Card");
            DropIndex("dbo.CardHistory", new[] { "ID" });
            AlterColumn("dbo.CardHistory", "ID", c => c.Int());
            RenameColumn(table: "dbo.CardHistory", name: "ID", newName: "card_ID");
            CreateIndex("dbo.CardHistory", "card_ID");
            AddForeignKey("dbo.CardHistory", "card_ID", "dbo.Card", "ID");
        }
    }
}
