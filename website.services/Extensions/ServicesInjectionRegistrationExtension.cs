using Microsoft.Extensions.DependencyInjection;
using website.services.Interfaces;

namespace website.services.Extensions
{
    public static class ServicesInjectionRegistrationExtension
    {
        public static void AddInjections(this IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IGoogleRecaptchaService, GoogleRecaptchaService>();
        }
    }
}
