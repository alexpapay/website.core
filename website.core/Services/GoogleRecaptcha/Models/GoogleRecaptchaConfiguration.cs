using website.core.Services.GoogleRecaptcha.Interfaces;

namespace website.core.Services.GoogleRecaptcha.Models
{
    public class GoogleRecaptchaConfiguration : IGoogleRecaptchaConfiguration
    {
        public string Key { get; set; }
        public string Secret { get; set; }
    }
}