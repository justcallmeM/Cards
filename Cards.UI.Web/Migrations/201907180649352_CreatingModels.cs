namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CardHistory",
                c => new
                    {
                        CardHistoryID = c.Int(nullable: false),
                        state = c.Int(nullable: false),
                        acquisitionDate = c.DateTime(nullable: false),
                        stateChangeDate = c.DateTime(nullable: false),
                        card_ID = c.Long(),
                    })
                .PrimaryKey(t => t.CardHistoryID)
                .ForeignKey("dbo.Card", t => t.card_ID)
                .Index(t => t.card_ID);
            
            CreateTable(
                "dbo.Card",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        state = c.Int(nullable: false),
                        expirationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CardHistory", "card_ID", "dbo.Card");
            DropIndex("dbo.CardHistory", new[] { "card_ID" });
            DropTable("dbo.Card");
            DropTable("dbo.CardHistory");
        }
    }
}
