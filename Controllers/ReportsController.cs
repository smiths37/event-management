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
    public class ReportsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public ReportsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/Reports
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblReports>>> GetTblReports(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblReports>.CreateAsync(_context.TblReports, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/Reports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblReports>> GetTblReports(int id)
        {
            var tblReports = await _context.TblReports.FindAsync(id);

            if (tblReports == null)
            {
                return NotFound();
            }

            return tblReports;
        }

        // PUT: api/Reports/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblReports(int id, TblReports tblReports)
        {
            if (id != tblReports.ReportID)
            {
                return BadRequest();
            }

            _context.Entry(tblReports).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblReportsExists(id))
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

        // POST: api/Reports
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblReports>> PostTblReports(TblReports tblReports)
        {
            _context.TblReports.Add(tblReports);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblReports", new { id = tblReports.ReportID }, tblReports);
        }

        // DELETE: api/Reports/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblReports>> DeleteTblReports(int id)
        {
            var tblReports = await _context.TblReports.FindAsync(id);
            if (tblReports == null)
            {
                return NotFound();
            }

            _context.TblReports.Remove(tblReports);
            await _context.SaveChangesAsync();

            return tblReports;
        }

        private bool TblReportsExists(int id)
        {
            return _context.TblReports.Any(e => e.ReportID == id);
        }
    }
}
