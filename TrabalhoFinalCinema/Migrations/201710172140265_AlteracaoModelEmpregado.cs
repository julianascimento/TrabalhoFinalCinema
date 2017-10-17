namespace TrabalhoFinalCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoModelEmpregado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Filmes", "Horario", c => c.String());
            AlterColumn("dbo.Empregados", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Filmes", "Nome", c => c.String(nullable: false));
            DropColumn("dbo.Filmes", "Horário");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Filmes", "Horário", c => c.String());
            AlterColumn("dbo.Filmes", "Nome", c => c.String());
            AlterColumn("dbo.Empregados", "Nome", c => c.String());
            DropColumn("dbo.Filmes", "Horario");
        }
    }
}
