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
    public class MrnController : ControllerBase
    {
        private readonly JobManagerContext _context;

        public MrnController(JobManagerContext context)
        {
            _context = context;
        }

        // GET: api/Mrn
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblMrn>>> GetTblMrns()
        {
            return await _context.TblMrns.ToListAsync();
        }

        [HttpGet("MRNMaterialdata/{userid}")]
        public async Task<ActionResult<IEnumerable<TblMrn>>> GetMRNMaterialdata(string userid)
        {
            return await _context.TblMrns.Where(r => r.Updatedby==userid && r.Mrnid==null).ToListAsync();
        }

        // GET: api/Mrn/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblMrn>> GetTblMrn(int id)
        {
            var tblMrn = await _context.TblMrns.FindAsync(id);

            if (tblMrn == null)
            {
                return NotFound();
            }

            return tblMrn;
        }

        // PUT: api/Mrn/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblMrn(int id, TblMrn tblMrn)
        {
            if (id != tblMrn.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblMrn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblMrnExists(id))
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

        // POST: api/Mrn
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblMrn>> PostTblMrn(TblMrn tblMrn)
        {
            _context.TblMrns.Add(tblMrn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblMrn", new { id = tblMrn.Id }, tblMrn);
        }

        // DELETE: api/Mrn/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblMrn>> DeleteTblMrn(int id)
        {
            var tblMrn = await _context.TblMrns.FindAsync(id);
            if (tblMrn == null)
            {
                return NotFound();
            }

            _context.TblMrns.Remove(tblMrn);
            await _context.SaveChangesAsync();

            return tblMrn;
        }

        private bool TblMrnExists(int id)
        {
            return _context.TblMrns.Any(e => e.Id == id);
        }
    }
}
