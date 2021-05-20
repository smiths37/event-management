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
    public class NotesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public NotesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/Notes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblNotes>>> GetTblNotes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblNotes>.CreateAsync(_context.TblNotes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }


        // GET: api/Notes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblNotes>> GetTblNotes(int id)
        {
            var tblNotes = await _context.TblNotes.FindAsync(id);

            if (tblNotes == null)
            {
                return NotFound();
            }

            return tblNotes;
        }

        // PUT: api/Notes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblNotes(int id, TblNotes tblNotes)
        {
            if (id != tblNotes.NoteId)
            {
                return BadRequest();
            }

            _context.Entry(tblNotes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblNotesExists(id))
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

        // POST: api/Notes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblNotes>> PostTblNotes(TblNotes tblNotes)
        {
            _context.TblNotes.Add(tblNotes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblNotes", new { id = tblNotes.NoteId }, tblNotes);
        }

        // DELETE: api/Notes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblNotes>> DeleteTblNotes(int id)
        {
            var tblNotes = await _context.TblNotes.FindAsync(id);
            if (tblNotes == null)
            {
                return NotFound();
            }

            _context.TblNotes.Remove(tblNotes);
            await _context.SaveChangesAsync();

            return tblNotes;
        }

        private bool TblNotesExists(int id)
        {
            return _context.TblNotes.Any(e => e.NoteId == id);
        }

        [HttpGet]
        [Route("getCompanyNotes/{id}")]
        public ActionResult<List<TblNotes>> getCompanyNotes(int id)
        {
            List<TblNotes> companyNotes = _context.TblNotes.Where(e => e.CompanyId != null && e.CompanyId == id ).ToList();

            return companyNotes;
        }

        [HttpGet]
        [Route("getExhibitorNotes/{id}")]
        public ActionResult<List<TblNotes>> getExhibitorNotes(int id)
        {
            List<TblNotes> exhibitorNotes = _context.TblNotes.Where(e => e.ExhibitorId != null && e.ExhibitorId == id).ToList();
            
            return exhibitorNotes;
        }
    }
}
