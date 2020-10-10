using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobManagerAPI.Models;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using JobManagerAPI.Helpers;

namespace JobManagerAPI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly JobManagerContext _context;
        private readonly AppSettings _appSettings;
        public UsersController(JobManagerContext context, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblUser>>> GetTblUsers()
        {
            return await _context.TblUsers.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{userid}/{password}")]
        public async Task<ActionResult<TblUser>> GetTblUser(string userid,string password)
        {
            var tblUser = await _context.TblUsers.Where(r=>r.UserId== userid && r.Password==password).SingleOrDefaultAsync();

            if (tblUser == null)
            {
                return NotFound();
            }

            return tblUser;
        }

       
        [HttpPost("Login")]
        public async Task<ActionResult<TblUser>> Login([FromBody] TblUser user)
        {
            var tblUser = await _context.TblUsers.Where(r => r.UserId == user.UserId && r.Password == user.Password).SingleOrDefaultAsync();
            if (tblUser == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, tblUser.UserId.ToString()),
                    new Claim(ClaimTypes.Role, tblUser.AccessLevel)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            tblUser.Token = tokenHandler.WriteToken(token);

            return tblUser;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblUser(int id, TblUser tblUser)
        {
            if (id != tblUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblUserExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblUser>> PostTblUser(TblUser tblUser)
        {
            _context.TblUsers.Add(tblUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblUser", new { id = tblUser.Id }, tblUser);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblUser>> DeleteTblUser(int id)
        {
            var tblUser = await _context.TblUsers.FindAsync(id);
            if (tblUser == null)
            {
                return NotFound();
            }

            _context.TblUsers.Remove(tblUser);
            await _context.SaveChangesAsync();

            return tblUser;
        }

        private bool TblUserExists(int id)
        {
            return _context.TblUsers.Any(e => e.Id == id);
        }
    }
}
