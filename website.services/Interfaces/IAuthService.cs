using System.Collections.Generic;
using System.Threading.Tasks;
using website.core.Models.Auth;

namespace website.services.Interfaces
{
    public interface IAuthService
    {
        /// <summary>
        /// Get all unitronics downoader users.
        /// </summary>
        /// <returns>List of users.</returns>
        Task<List<User>> GetAllUsers();
    }
}