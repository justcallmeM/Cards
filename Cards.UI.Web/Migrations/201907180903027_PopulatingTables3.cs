namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingTables3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Card", "number", c => c.Int(nullable: false));
            DropColumn("dbo.Card", "cardNR");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Card", "cardNR", c => c.Int(nullable: false));
            DropColumn("dbo.Card", "number");
        }
    }
}
