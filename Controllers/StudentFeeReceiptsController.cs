﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using schools.Models;

namespace schools.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using schools.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<StudentFeeReceipt>("StudentFeeReceipts");
    builder.EntitySet<PaymentDetail>("PaymentDetails"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class StudentFeeReceiptsController : ODataController
    {
        private StpaulsEntities db = new StpaulsEntities();

        // GET: odata/StudentFeeReceipts
        [EnableQuery]
        public IQueryable<StudentFeeReceipt> GetStudentFeeReceipts()
        {
            return db.StudentFeeReceipts;
        }

        // GET: odata/StudentFeeReceipts(5)
        [EnableQuery]
        public SingleResult<StudentFeeReceipt> GetStudentFeeReceipt([FromODataUri] short key)
        {
            return SingleResult.Create(db.StudentFeeReceipts.Where(studentFeeReceipt => studentFeeReceipt.StudentReceiptId == key));
        }

        // PUT: odata/StudentFeeReceipts(5)
        public async Task<IHttpActionResult> Put([FromODataUri] short key, Delta<StudentFeeReceipt> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            StudentFeeReceipt studentFeeReceipt = await db.StudentFeeReceipts.FindAsync(key);
            if (studentFeeReceipt == null)
            {
                return NotFound();
            }

            patch.Put(studentFeeReceipt);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentFeeReceiptExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(studentFeeReceipt);
        }

        // POST: odata/StudentFeeReceipts
        public async Task<IHttpActionResult> Post(StudentFeeReceipt studentFeeReceipt)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.StudentFeeReceipts.Add(studentFeeReceipt);
            await db.SaveChangesAsync();

            return Created(studentFeeReceipt);
        }

        // PATCH: odata/StudentFeeReceipts(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] short key, Delta<StudentFeeReceipt> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            StudentFeeReceipt studentFeeReceipt = await db.StudentFeeReceipts.FindAsync(key);
            if (studentFeeReceipt == null)
            {
                return NotFound();
            }

            patch.Patch(studentFeeReceipt);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentFeeReceiptExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(studentFeeReceipt);
        }

        // DELETE: odata/StudentFeeReceipts(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] short key)
        {
            StudentFeeReceipt studentFeeReceipt = await db.StudentFeeReceipts.FindAsync(key);
            if (studentFeeReceipt == null)
            {
                return NotFound();
            }

            db.StudentFeeReceipts.Remove(studentFeeReceipt);
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/StudentFeeReceipts(5)/PaymentDetails
        [EnableQuery]
        public IQueryable<PaymentDetail> GetPaymentDetails([FromODataUri] short key)
        {
            return db.StudentFeeReceipts.Where(m => m.StudentReceiptId == key).SelectMany(m => m.PaymentDetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentFeeReceiptExists(short key)
        {
            return db.StudentFeeReceipts.Count(e => e.StudentReceiptId == key) > 0;
        }
    }
}
