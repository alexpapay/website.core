using System.Threading.Tasks;

namespace website.core.Services.GoogleRecaptcha.Interfaces
{
    public interface IGoogleRecaptchaService
    {
        /// <summary>
        /// Is recaptcha passed.
        /// </summary>
        /// <param name="googleRecaptchaResponse">Recaptcha response from Google.</param>
        /// <param name="secret">Secret key string.</param>
        /// <returns>Result: true or false.</returns>
        Task<bool> IsReCaptchaPassedAsync(string googleRecaptchaResponse, string secret);
    }
}