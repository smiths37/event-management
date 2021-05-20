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
    public class CompanyTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public CompanyTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/CompanyTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblCompanyTypes>>> GetTblCompanyTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblCompanyTypes>.CreateAsync(_context.TblCompanyTypes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/CompanyTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCompanyTypes>> GetTblCompanyTypes(int id)
        {
            var tblCompanyTypes = await _context.TblCompanyTypes.FindAsync(id);

            if (tblCompanyTypes == null)
            {
                return NotFound();
            }

            return tblCompanyTypes;
        }

        // PUT: api/CompanyTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCompanyTypes(int id, TblCompanyTypes tblCompanyTypes)
        {
            if (id != tblCompanyTypes.CompanyTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tblCompanyTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCompanyTypesExists(id))
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

        // POST: api/CompanyTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblCompanyTypes>> PostTblCompanyTypes(TblCompanyTypes tblCompanyTypes)
        {
            _context.TblCompanyTypes.Add(tblCompanyTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblCompanyTypes", new { id = tblCompanyTypes.CompanyTypeId }, tblCompanyTypes);
        }

        // DELETE: api/CompanyTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblCompanyTypes>> DeleteTblCompanyTypes(int id)
        {
            var tblCompanyTypes = await _context.TblCompanyTypes.FindAsync(id);
            if (tblCompanyTypes == null)
            {
                return NotFound();
            }

            _context.TblCompanyTypes.Remove(tblCompanyTypes);
            await _context.SaveChangesAsync();

            return tblCompanyTypes;
        }

        private bool TblCompanyTypesExists(int id)
        {
            return _context.TblCompanyTypes.Any(e => e.CompanyTypeId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblCompanyTypes tblCompanyTypes)
        {
            return _context.TblCompanyTypes.Any(
                e => e.CompanyTypeDesc == tblCompanyTypes.CompanyTypeDesc
                && e.CompanyTypeId != tblCompanyTypes.CompanyTypeId
            );
        }
    }
}
