using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecAPI.Models
{
    public class recPayment
    {

        // Note , a better data type for some properties will be optimized through a future optimization
        // for example: changing some properties from int to Short or byte ( depends on the length of the number)
        // since i am using code first, there will not be a problem for our DB


        // i prefer to use "Pascal case" while writing properties, but i copied the names from the message you sent
        public int Id { get; set; }
        [Required]
        public int Comp_Id { get; set; }
        [Required]
        public int RECEIPT_NO { get; set; }
        public DateTime RECEIPT_DATE { get; set; }
        public int COLLECTOR_ID { get; set; }
        [Required]
        public int CUSTOMER_ID { get; set; }
        [Required]
        public int PAYMENT_TYPE_ID { get; set; }
        [Required]
        public float PAYMENT_AMOUNT { get; set; }
        [Required]
        public long INVOICE_NO { get; set; }
        public DateTime INVOICE_DATE { get; set; }
        public float INVOICE_AMOUNT_SETTELD { get; set; }
        public int CHEQUE_NO { get; set; }
        public DateTime CHEQUE_DATE { get; set; }
        public long BANK_ID { get; set; }
        public long AUTHENTICATION_CODE { get; set; }
        public string CUSTOMER_REMARKS { get; set; }










    }
}