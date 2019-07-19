namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingTables2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Card", "cardNR", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Card", "cardNR", c => c.Long(nullable: false));
        }
    }
}
