namespace website.core.Interfaces.GoogleRecaptcha
{
    public interface IGoogleRecaptchaConfiguration
    {
        string Key { get; set; }

        string Secret { get; set; }
    }
}