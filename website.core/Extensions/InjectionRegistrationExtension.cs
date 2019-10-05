using Microsoft.Extensions.DependencyInjection;
using website.core.Services.Email;
using website.core.Services.Email.Interfaces;
using website.core.Services.GoogleRecaptcha;
using website.core.Services.GoogleRecaptcha.Interfaces;

namespace website.core.Extensions
{
    public static class InjectionRegistrationExtension
    {
        public static void AddInjections(this IServiceCollection services)
        {
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IGoogleRecaptchaService, GoogleRecaptchaService>();
        }
    }
}
