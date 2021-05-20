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
    public class PaymentTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public PaymentTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/PaymentTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblPaymentTypes>>> GetTblPaymentTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblPaymentTypes>.CreateAsync(_context.TblPaymentTypes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/PaymentTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPaymentTypes>> GetTblPaymentTypes(int id)
        {
            var tblPaymentTypes = await _context.TblPaymentTypes.FindAsync(id);

            if (tblPaymentTypes == null)
            {
                return NotFound();
            }

            return tblPaymentTypes;
        }

        // PUT: api/PaymentTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPaymentTypes(int id, TblPaymentTypes tblPaymentTypes)
        {
            if (id != tblPaymentTypes.PaymentTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tblPaymentTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPaymentTypesExists(id))
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

        // POST: api/PaymentTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblPaymentTypes>> PostTblPaymentTypes(TblPaymentTypes tblPaymentTypes)
        {
            _context.TblPaymentTypes.Add(tblPaymentTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblPaymentTypes", new { id = tblPaymentTypes.PaymentTypeId }, tblPaymentTypes);
        }

        // DELETE: api/PaymentTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblPaymentTypes>> DeleteTblPaymentTypes(int id)
        {
            var tblPaymentTypes = await _context.TblPaymentTypes.FindAsync(id);
            if (tblPaymentTypes == null)
            {
                return NotFound();
            }

            _context.TblPaymentTypes.Remove(tblPaymentTypes);
            await _context.SaveChangesAsync();

            return tblPaymentTypes;
        }

        private bool TblPaymentTypesExists(int id)
        {
            return _context.TblPaymentTypes.Any(e => e.PaymentTypeId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblPaymentTypes tblPaymentTypes)
        {
            return _context.TblPaymentTypes.Any(
                e => e.PaymentTypeDesc == tblPaymentTypes.PaymentTypeDesc
                && e.PaymentTypeId != tblPaymentTypes.PaymentTypeId
            );
        }
    }
}
