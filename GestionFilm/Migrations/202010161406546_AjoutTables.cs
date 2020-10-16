namespace GestionFilm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Year = c.Int(nullable: false),
                        Studio = c.String(),
                        PersonnalityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieId)
                .ForeignKey("dbo.Personnalities", t => t.PersonnalityId, cascadeDelete: true)
                .Index(t => t.PersonnalityId);
            
            CreateTable(
                "dbo.Personnalities",
                c => new
                    {
                        PersonnalityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FirstName = c.String(),
                        Birth = c.DateTime(nullable: false),
                        Nationnality = c.String(),
                        Actor = c.Boolean(nullable: false),
                        Real = c.Boolean(nullable: false),
                        Producer = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PersonnalityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "PersonnalityId", "dbo.Personnalities");
            DropIndex("dbo.Movies", new[] { "PersonnalityId" });
            DropTable("dbo.Personnalities");
            DropTable("dbo.Movies");
        }
    }
}
