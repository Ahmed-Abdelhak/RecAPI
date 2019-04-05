namespace RecAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.recPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Comp_Id = c.Int(nullable: false),
                        RECEIPT_NO = c.Int(nullable: false),
                        RECEIPT_DATE = c.DateTime(nullable: false),
                        COLLECTOR_ID = c.Int(nullable: false),
                        CUSTOMER_ID = c.Int(nullable: false),
                        PAYMENT_TYPE_ID = c.Int(nullable: false),
                        PAYMENT_AMOUNT = c.Single(nullable: false),
                        INVOICE_NO = c.Int(nullable: false),
                        INVOICE_DATE = c.DateTime(nullable: false),
                        INVOICE_AMOUNT_SETTELD = c.Single(nullable: false),
                        CHEQUE_NO = c.Int(nullable: false),
                        CHEQUE_DATE = c.DateTime(nullable: false),
                        BANK_ID = c.Int(nullable: false),
                        AUTHENTICATION_CODE = c.Long(nullable: false),
                        CUSTOMER_REMARKS = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.recPayments");
        }
    }
}
