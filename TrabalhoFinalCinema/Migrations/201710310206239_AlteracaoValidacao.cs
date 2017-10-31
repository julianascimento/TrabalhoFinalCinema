namespace TrabalhoFinalCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoValidacao : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empregados", "Funcao", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empregados", "Funcao", c => c.String());
        }
    }
}
