namespace TrabalhoFinalCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoValidacaoComidas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comidas", "Tipo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comidas", "Tipo", c => c.String());
        }
    }
}
