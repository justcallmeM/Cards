namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Card", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Card", "Discriminator");
        }
    }
}
