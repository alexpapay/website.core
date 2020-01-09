using System.Collections.Generic;
using System.Threading.Tasks;
using website.core.Models.Auth;
using website.dal.Interfaces;
using website.services.Interfaces;

namespace website.services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        /// <summary>
        /// Get all unitronics downoader users.
        /// </summary>
        /// <returns>List of users.</returns>
        public async Task<List<User>> GetAllUsers()
        {
            return await _authRepository.GetAllUsers();
        }
    }
}
