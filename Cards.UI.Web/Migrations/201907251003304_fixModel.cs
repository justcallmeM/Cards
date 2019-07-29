namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Card", "blockButton");
            DropColumn("dbo.Card", "unblockButton");
            DropColumn("dbo.Card", "historyButton");
            DropColumn("dbo.Card", "deleteButton");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Card", "deleteButton", c => c.String());
            AddColumn("dbo.Card", "historyButton", c => c.String());
            AddColumn("dbo.Card", "unblockButton", c => c.String());
            AddColumn("dbo.Card", "blockButton", c => c.String());
        }
    }
}
