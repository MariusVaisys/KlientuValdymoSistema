namespace ClassLibrary2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Klientas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vardas = c.String(nullable: false, maxLength: 50),
                        Pavarde = c.String(nullable: false, maxLength: 50),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Klientas");
        }
    }
}
