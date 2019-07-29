namespace Cards.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateMigration2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Card", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Card", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
