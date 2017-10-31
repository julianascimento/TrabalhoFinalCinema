namespace TrabalhoFinalCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoValidacaoFilmes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Filmes", "Genero", c => c.String(nullable: false));
            AlterColumn("dbo.Filmes", "IdadeMinima", c => c.String(nullable: false));
            AlterColumn("dbo.Filmes", "Horario", c => c.String(nullable: false));
            AlterColumn("dbo.Filmes", "Linguagem", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Filmes", "Linguagem", c => c.String());
            AlterColumn("dbo.Filmes", "Horario", c => c.String());
            AlterColumn("dbo.Filmes", "IdadeMinima", c => c.String());
            AlterColumn("dbo.Filmes", "Genero", c => c.String());
        }
    }
}
