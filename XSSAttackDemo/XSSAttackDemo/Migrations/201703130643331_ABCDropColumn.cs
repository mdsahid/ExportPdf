namespace XSSAttackDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ABCDropColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "BirthDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
