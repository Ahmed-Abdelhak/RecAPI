using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RecAPI.Models;

namespace RecAPI.Controllers
{
    public class RecPaymentController : ApiController
    {
        private readonly RecContext _context;   // it's better to use Repository Design Pattern and Unit Of Work

        public RecPaymentController(RecContext context)
        {
            _context = context;
        }
        protected override void Dispose(bool disposing) // just to release  resources 
        {
            base.Dispose(disposing);
            _context.Dispose();
        }

        // POST api/RecPayment
        public IHttpActionResult Post(recPayment recPayment)
        {
            if (!ModelState.IsValid)
                return BadRequest();


            // Authorization Check
            //if (condition)  
            //return StatusCode(HttpStatusCode.Forbidden);



            //if (condition)
            //return StatusCode(HttpStatusCode.NoContent);


            _context.RecPayments.Add(recPayment);  // AutoMapper could be used
            _context.SaveChanges();

            return Ok();
        }

      
    }
}