namespace website.core.Services.GoogleRecaptcha.Interfaces
{
    public interface IGoogleRecaptchaConfiguration
    {
        string Key { get; set; }

        string Secret { get; set; }
    }
}