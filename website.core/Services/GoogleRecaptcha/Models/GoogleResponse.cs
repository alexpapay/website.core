using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace website.core.Services.GoogleRecaptcha.Models
{
    class GoogleResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("error-codes")]
        public List<string> ErrorCodes { get; set; }
    }
}