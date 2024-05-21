namespace SACLA_9205.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class B : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Papers",
                c => new
                    {
                        PaperID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Abstract = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        DateSubmitted = c.DateTime(nullable: false),
                        TopicID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PaperID);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        TopicID = c.Int(nullable: false, identity: true),
                        TopicName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TopicID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Topics");
            DropTable("dbo.Papers");
        }
    }
}
