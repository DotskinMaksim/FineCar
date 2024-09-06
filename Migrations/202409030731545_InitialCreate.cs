namespace FineCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarNumber = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        dateTime = c.DateTime(nullable: false),
                        Excess = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fines");
        }
    }
}
