namespace Movy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToMovies : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.Movies", "NumberAvailable", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
