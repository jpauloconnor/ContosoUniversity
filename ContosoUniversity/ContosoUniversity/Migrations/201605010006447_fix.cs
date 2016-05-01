namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "GradYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "GradYear", c => c.Int());
        }
    }
}
