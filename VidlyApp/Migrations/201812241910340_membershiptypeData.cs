using System.Web.UI.WebControls;

namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membershiptypeData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES(2, 'Annually', 30, 12, 10)");
            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES(3, 'Monthly', 30, 12, 10)");
            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES(4, 'Quarterly', 30, 12, 10)");


            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE Id = 1");


        }

        public override void Down()
        {
        }
    }
}
