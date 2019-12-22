using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using website.core.Models.Auth;
using website.dal.Interfaces;
using website.data;

namespace website.dal.Auth
{
    public class AuthRepository : IAuthRepository
    {
        private readonly IdentityContext _context;

        public AuthRepository(IdentityContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all identity users from database.
        /// </summary>
        /// <returns>List of identity users.</returns>
        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}