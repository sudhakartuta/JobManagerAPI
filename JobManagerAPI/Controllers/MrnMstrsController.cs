using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobManagerAPI.Models;

namespace JobManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MrnMstrsController : ControllerBase
    {
        private readonly JobManagerContext _context;

        public MrnMstrsController(JobManagerContext context)
        {
            _context = context;
        }

        // GET: api/MrnMstrs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblMrnMstr>>> GetTblMrnMstrs()
        {
            return await _context.TblMrnMstrs.ToListAsync();
        }

        // GET: api/MrnMstrs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblMrnMstr>> GetTblMrnMstr(int id)
        {
            var tblMrnMstr = await _context.TblMrnMstrs.FindAsync(id);

            if (tblMrnMstr == null)
            {
                return NotFound();
            }

            return tblMrnMstr;
        }

        // PUT: api/MrnMstrs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblMrnMstr(int id, TblMrnMstr tblMrnMstr)
        {
            if (id != tblMrnMstr.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblMrnMstr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblMrnMstrExists(id))
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

        // POST: api/MrnMstrs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblMrnMstr>> PostTblMrnMstr(TblMrnMstr tblMrnMstr)
        {
            _context.TblMrnMstrs.Add(tblMrnMstr);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblMrnMstr", new { id = tblMrnMstr.Id }, tblMrnMstr);
        }

        // DELETE: api/MrnMstrs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblMrnMstr>> DeleteTblMrnMstr(int id)
        {
            var tblMrnMstr = await _context.TblMrnMstrs.FindAsync(id);
            if (tblMrnMstr == null)
            {
                return NotFound();
            }

            _context.TblMrnMstrs.Remove(tblMrnMstr);
            await _context.SaveChangesAsync();

            return tblMrnMstr;
        }

        private bool TblMrnMstrExists(int id)
        {
            return _context.TblMrnMstrs.Any(e => e.Id == id);
        }
    }
}
