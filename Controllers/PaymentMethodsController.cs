using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeetingTrak.Data.Models;
using MeetingTrak.Data;

namespace MeetingTrak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public PaymentMethodsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/PaymentMethods
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblPaymentMethods>>> GetTblPaymentMethods(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblPaymentMethods>.CreateAsync(_context.TblPaymentMethods, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/PaymentMethods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPaymentMethods>> GetTblPaymentMethods(int id)
        {
            var tblPaymentMethods = await _context.TblPaymentMethods.FindAsync(id);

            if (tblPaymentMethods == null)
            {
                return NotFound();
            }

            return tblPaymentMethods;
        }

        // PUT: api/PaymentMethods/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPaymentMethods(int id, TblPaymentMethods tblPaymentMethods)
        {
            if (id != tblPaymentMethods.PaymentMethodId)
            {
                return BadRequest();
            }

            _context.Entry(tblPaymentMethods).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPaymentMethodsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PaymentMethods
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblPaymentMethods>> PostTblPaymentMethods(TblPaymentMethods tblPaymentMethods)
        {
            _context.TblPaymentMethods.Add(tblPaymentMethods);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblPaymentMethods", new { id = tblPaymentMethods.PaymentMethodId }, tblPaymentMethods);
        }

        // DELETE: api/PaymentMethods/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblPaymentMethods>> DeleteTblPaymentMethods(int id)
        {
            var tblPaymentMethods = await _context.TblPaymentMethods.FindAsync(id);
            if (tblPaymentMethods == null)
            {
                return NotFound();
            }

            _context.TblPaymentMethods.Remove(tblPaymentMethods);
            await _context.SaveChangesAsync();

            return tblPaymentMethods;
        }

        private bool TblPaymentMethodsExists(int id)
        {
            return _context.TblPaymentMethods.Any(e => e.PaymentMethodId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblPaymentMethods tblPaymentMethods)
        {
            return _context.TblPaymentMethods.Any(
                e => e.PaymentMethodDesc == tblPaymentMethods.PaymentMethodDesc
                && e.PaymentMethodId != tblPaymentMethods.PaymentMethodId
            );
        }
    }
}
