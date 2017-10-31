namespace TrabalhoFinalCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoValidacaoEmpregados : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empregados", "Aniversario", c => c.String(nullable: false));
            AlterColumn("dbo.Empregados", "CPF", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empregados", "CPF", c => c.String());
            AlterColumn("dbo.Empregados", "Aniversario", c => c.String());
        }
    }
}
