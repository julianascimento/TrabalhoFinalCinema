namespace TrabalhoFinalCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelSalas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Salas", "TresD", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Salas", "TresD", c => c.String(nullable: false));
        }
    }
}
