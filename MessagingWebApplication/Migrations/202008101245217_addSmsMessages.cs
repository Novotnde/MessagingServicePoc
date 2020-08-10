namespace MessagingWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSmsMessages : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.SmsMessages");
        }
    }
}
