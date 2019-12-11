namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _898989 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classes", "Name", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Classes", "Name", c => c.String(maxLength: 50));
        }
    }
}
