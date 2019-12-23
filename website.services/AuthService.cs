using System.Collections.Generic;
using System.Threading.Tasks;
using website.core.Models.Auth;
using website.dal.Auth;
using website.services.Interfaces;

namespace website.services
{
    public class AuthService : IAuthService
    {
        private readonly AuthRepository _identityRepository;

        public AuthService(AuthRepository identityRepository)
        {
            _identityRepository = identityRepository;
        }

        /// <summary>
        /// Get all unitronics downoader users.
        /// </summary>
        /// <returns>List of users.</returns>
        public async Task<List<User>> GetAllUsers()
        {
            return await _identityRepository.GetAllUsers();
        }
    }
}
