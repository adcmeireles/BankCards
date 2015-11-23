namespace BankCards.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Banks", "BankName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Banks", "BankName", c => c.String());
        }
    }
}
