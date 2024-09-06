namespace FineCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarOwners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonalCode = c.String(),
                        CarNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Fines", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Fines", "CarNumber");
            DropColumn("dbo.Fines", "Name");
            DropColumn("dbo.Fines", "Email");
            DropColumn("dbo.Fines", "PhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fines", "PhoneNumber", c => c.String());
            AddColumn("dbo.Fines", "Email", c => c.String());
            AddColumn("dbo.Fines", "Name", c => c.String());
            AddColumn("dbo.Fines", "CarNumber", c => c.String());
            DropColumn("dbo.Fines", "UserId");
            DropTable("dbo.CarOwners");
        }
    }
}
