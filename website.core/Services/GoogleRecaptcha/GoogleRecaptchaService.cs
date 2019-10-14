using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using website.core.Services.GoogleRecaptcha.Interfaces;
using website.core.Services.GoogleRecaptcha.Models;

namespace website.core.Services.GoogleRecaptcha
{
    public class GoogleRecaptchaService : IGoogleRecaptchaService
    {
        /// <summary>
        /// Is recaptcha passed.
        /// </summary>
        /// <param name="googleRecaptchaResponse">Recaptcha response from Google.</param>
        /// <param name="secret">Secret key string.</param>
        /// <returns>Result: true or false.</returns>
        public async Task<bool> IsReCaptchaPassedAsync(string googleRecaptchaResponse, string secret)
        {
            HttpClient httpClient = new HttpClient();

            FormUrlEncodedContent content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("secret", secret),
                new KeyValuePair<string, string>("response", googleRecaptchaResponse)
            });

            HttpResponseMessage postResult =
                await httpClient.PostAsync($"https://www.google.com/recaptcha/api/siteverify", content);

            if (postResult.StatusCode != HttpStatusCode.OK)
                return false;

            string jsonResult = postResult.Content.ReadAsStringAsync().Result;

            GoogleResponse jsonData =
                JsonSerializer.Deserialize<GoogleResponse>(jsonResult, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return jsonData.Success;
        }
    }
}
