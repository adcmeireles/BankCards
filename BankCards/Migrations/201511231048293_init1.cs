namespace BankCards.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cards", "CardNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cards", "CardNumber", c => c.Int(nullable: false));
        }
    }
}
