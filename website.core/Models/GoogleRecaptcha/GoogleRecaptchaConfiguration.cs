using website.core.Interfaces.GoogleRecaptcha;

namespace website.core.Models.GoogleRecaptcha
{
    public class GoogleRecaptchaConfiguration : IGoogleRecaptchaConfiguration
    {
        public string Key { get; set; }
        public string Secret { get; set; }
    }
}