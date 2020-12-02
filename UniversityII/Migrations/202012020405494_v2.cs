namespace UniversityII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Estado", c => c.String());
            DropColumn("dbo.People", "Activo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Activo", c => c.String());
            DropColumn("dbo.People", "Estado");
        }
    }
}
