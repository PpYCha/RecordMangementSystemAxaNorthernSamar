namespace RecordManagementSystemInAxaNSamar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nulll : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "IsActive", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "IsActive", c => c.String());
        }
    }
}
