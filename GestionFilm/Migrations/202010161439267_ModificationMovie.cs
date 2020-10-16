namespace GestionFilm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificationMovie : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "PersonnalityId", "dbo.Personnalities");
            DropIndex("dbo.Movies", new[] { "PersonnalityId" });
            CreateTable(
                "dbo.PersonnalityMovies",
                c => new
                    {
                        Personnality_PersonnalityId = c.Int(nullable: false),
                        Movie_MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Personnality_PersonnalityId, t.Movie_MovieId })
                .ForeignKey("dbo.Personnalities", t => t.Personnality_PersonnalityId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId, cascadeDelete: true)
                .Index(t => t.Personnality_PersonnalityId)
                .Index(t => t.Movie_MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonnalityMovies", "Movie_MovieId", "dbo.Movies");
            DropForeignKey("dbo.PersonnalityMovies", "Personnality_PersonnalityId", "dbo.Personnalities");
            DropIndex("dbo.PersonnalityMovies", new[] { "Movie_MovieId" });
            DropIndex("dbo.PersonnalityMovies", new[] { "Personnality_PersonnalityId" });
            DropTable("dbo.PersonnalityMovies");
            CreateIndex("dbo.Movies", "PersonnalityId");
            AddForeignKey("dbo.Movies", "PersonnalityId", "dbo.Personnalities", "PersonnalityId", cascadeDelete: true);
        }
    }
}
