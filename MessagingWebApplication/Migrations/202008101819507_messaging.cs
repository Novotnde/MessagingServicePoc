namespace MessagingWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messaging : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.SmsMessages");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SmsMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sender = c.String(nullable: false),
                        Reciever = c.String(nullable: false),
                        Body = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
