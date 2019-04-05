namespace RecAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataTypeForBankIdandInvoiceNo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.recPayments", "INVOICE_NO", c => c.Long(nullable: false));
            AlterColumn("dbo.recPayments", "BANK_ID", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.recPayments", "BANK_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.recPayments", "INVOICE_NO", c => c.Int(nullable: false));
        }
    }
}
