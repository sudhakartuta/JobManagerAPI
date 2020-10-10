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
    public class SupliersController : ControllerBase
    {
        private readonly JobManagerContext _context;

        public SupliersController(JobManagerContext context)
        {
            _context = context;
        }

        // GET: api/Supliers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblSuplier>>> GetTblSupliers()
        {
            return await _context.TblSupliers.ToListAsync();
        }

        // GET: api/Supliers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblSuplier>> GetTblSuplier(int id)
        {
            var tblSuplier = await _context.TblSupliers.FindAsync(id);

            if (tblSuplier == null)
            {
                return NotFound();
            }

            return tblSuplier;
        }

        // PUT: api/Supliers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblSuplier(int id, TblSuplier tblSuplier)
        {
            if (id != tblSuplier.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblSuplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblSuplierExists(id))
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

        // POST: api/Supliers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblSuplier>> PostTblSuplier(TblSuplier tblSuplier)
        {
            _context.TblSupliers.Add(tblSuplier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblSuplier", new { id = tblSuplier.Id }, tblSuplier);
        }

        // DELETE: api/Supliers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblSuplier>> DeleteTblSuplier(int id)
        {
            var tblSuplier = await _context.TblSupliers.FindAsync(id);
            if (tblSuplier == null)
            {
                return NotFound();
            }

            _context.TblSupliers.Remove(tblSuplier);
            await _context.SaveChangesAsync();

            return tblSuplier;
        }

        private bool TblSuplierExists(int id)
        {
            return _context.TblSupliers.Any(e => e.Id == id);
        }
    }
}
