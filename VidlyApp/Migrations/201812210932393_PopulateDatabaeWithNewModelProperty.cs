namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDatabaeWithNewModelProperty : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name = 'Pay as you go' WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
