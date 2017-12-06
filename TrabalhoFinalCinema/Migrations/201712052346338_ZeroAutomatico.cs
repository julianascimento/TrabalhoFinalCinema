namespace TrabalhoFinalCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZeroAutomatico : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empregados", "Idade", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empregados", "Idade", c => c.Int(nullable: false));
        }
    }
}
