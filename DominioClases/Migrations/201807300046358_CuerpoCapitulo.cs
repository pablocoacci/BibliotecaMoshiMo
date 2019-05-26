namespace DominioClases.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CuerpoCapitulo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Capitulos", "ContenidoCuerpo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Capitulos", "ContenidoCuerpo");
        }
    }
}
