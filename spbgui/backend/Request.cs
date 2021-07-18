using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace spbgui.backend
{
    public static class Request
    {
        public static async Task<ApiClass> ApiRequest(string param)
        {
            if (string.IsNullOrWhiteSpace(param))
            {
                throw new Exception("parameter cannot be null or empty");
            }

            var client = new HttpClient();
            var url = "https://api.intellivoid.net" + $"spamprotection/v1/lookup?query={param}";
            var s = new HttpRequestMessage(HttpMethod.Get, url);
            s.Headers.Add("User-Agent", "SpamProtection GUI");
            var resp = await client.SendAsync(s);
            if (resp == null || resp.Content == null)
            {
                return null;
            }

            var str = await resp.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<ApiClass>(str);

        }
    }
}
