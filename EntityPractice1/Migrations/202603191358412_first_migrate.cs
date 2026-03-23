namespace EntityPractice1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first_migrate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Pass = c.String(nullable: false),
                        Gender = c.String(),
                        dob = c.DateTime(nullable: false),
                        profession = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentModels");
        }
    }
}
