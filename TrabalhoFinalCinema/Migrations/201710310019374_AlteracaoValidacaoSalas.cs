namespace TrabalhoFinalCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoValidacaoSalas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Salas", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Salas", "TresD", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Salas", "TresD", c => c.String());
            AlterColumn("dbo.Salas", "Nome", c => c.String());
        }
    }
}
