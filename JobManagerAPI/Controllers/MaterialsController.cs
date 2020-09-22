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
    public class MaterialsController : ControllerBase
    {
        private readonly JobManagerContext _context;

        public MaterialsController(JobManagerContext context)
        {
            _context = context;
        }

        // GET: api/Materials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblMaterial>>> GetTblMaterials()
        {
            return await _context.TblMaterials.ToListAsync();
        }

        [HttpGet("MaterialType")]
        public async Task<ActionResult<IEnumerable<string>>> GetMaterialType()
        {
            return await _context.TblMaterials.GroupBy(a => a.MaterialType).OrderBy(r => r.Key).Select(r=>r.Key).ToListAsync();
        }

        [HttpGet("Material/{MaterialType}")]
        public async Task<ActionResult<IEnumerable<Material>>> GetMaterial(string MaterialType)
        {
            return await _context.TblMaterials.Where(r => r.MaterialType == MaterialType).Select(a => new Material { Code = a.Code, MaterialName = a.Material }).ToListAsync();
        }

        // GET: api/Materials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblMaterial>> GetTblMaterial(int id)
        {
            var tblMaterial = await _context.TblMaterials.FindAsync(id);

            if (tblMaterial == null)
            {
                return NotFound();
            }

            return tblMaterial;
        }

        // PUT: api/Materials/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblMaterial(int id, TblMaterial tblMaterial)
        {
            if (id != tblMaterial.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblMaterial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblMaterialExists(id))
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

        // POST: api/Materials
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblMaterial>> PostTblMaterial(TblMaterial tblMaterial)
        {
            _context.TblMaterials.Add(tblMaterial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblMaterial", new { id = tblMaterial.Id }, tblMaterial);
        }

        // DELETE: api/Materials/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblMaterial>> DeleteTblMaterial(int id)
        {
            var tblMaterial = await _context.TblMaterials.FindAsync(id);
            if (tblMaterial == null)
            {
                return NotFound();
            }

            _context.TblMaterials.Remove(tblMaterial);
            await _context.SaveChangesAsync();

            return tblMaterial;
        }

        private bool TblMaterialExists(int id)
        {
            return _context.TblMaterials.Any(e => e.Id == id);
        }
    }
}
