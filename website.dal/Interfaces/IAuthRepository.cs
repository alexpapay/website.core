using System.Collections.Generic;
using System.Threading.Tasks;
using website.core.Models.Auth;

namespace website.dal.Interfaces
{
    public interface IAuthRepository
    {
        /// <summary>
        /// Get all identity users from database.
        /// </summary>
        /// <returns>List of identity users.</returns>
        Task<List<User>> GetAllUsers();
    }
}