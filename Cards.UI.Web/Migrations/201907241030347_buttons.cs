namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buttons : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Card", "blockButton", c => c.String());
            AddColumn("dbo.Card", "historyButton", c => c.String());
            AddColumn("dbo.Card", "deleteButton", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Card", "deleteButton");
            DropColumn("dbo.Card", "historyButton");
            DropColumn("dbo.Card", "blockButton");
        }
    }
}
