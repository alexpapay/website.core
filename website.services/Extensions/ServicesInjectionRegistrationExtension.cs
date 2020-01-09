using Microsoft.Extensions.DependencyInjection;
using website.dal.Auth;
using website.dal.Interfaces;
using website.services.Interfaces;

namespace website.services.Extensions
{
    public static class ServicesInjectionRegistrationExtension
    {
        public static void AddInjections(this IServiceCollection services)
        {
            services.AddTransient<IAuthRepository, AuthRepository>();

            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IGoogleRecaptchaService, GoogleRecaptchaService>();
        }
    }
}
