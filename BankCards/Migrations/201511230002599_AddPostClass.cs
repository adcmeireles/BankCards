namespace BankCards.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "Bank_BankId", "dbo.Banks");
            DropForeignKey("dbo.Cards", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.Clients", new[] { "Bank_BankId" });
            DropIndex("dbo.Cards", new[] { "Client_ClientId" });
            RenameColumn(table: "dbo.Clients", name: "Bank_BankId", newName: "BankId");
            RenameColumn(table: "dbo.Cards", name: "Client_ClientId", newName: "ClientId");
            AlterColumn("dbo.Clients", "BankId", c => c.Int(nullable: false));
            AlterColumn("dbo.Cards", "ClientId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "BankId");
            CreateIndex("dbo.Cards", "ClientId");
            AddForeignKey("dbo.Clients", "BankId", "dbo.Banks", "BankId", cascadeDelete: true);
            AddForeignKey("dbo.Cards", "ClientId", "dbo.Clients", "ClientId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cards", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "BankId", "dbo.Banks");
            DropIndex("dbo.Cards", new[] { "ClientId" });
            DropIndex("dbo.Clients", new[] { "BankId" });
            AlterColumn("dbo.Cards", "ClientId", c => c.Int());
            AlterColumn("dbo.Clients", "BankId", c => c.Int());
            RenameColumn(table: "dbo.Cards", name: "ClientId", newName: "Client_ClientId");
            RenameColumn(table: "dbo.Clients", name: "BankId", newName: "Bank_BankId");
            CreateIndex("dbo.Cards", "Client_ClientId");
            CreateIndex("dbo.Clients", "Bank_BankId");
            AddForeignKey("dbo.Cards", "Client_ClientId", "dbo.Clients", "ClientId");
            AddForeignKey("dbo.Clients", "Bank_BankId", "dbo.Banks", "BankId");
        }
    }
}
