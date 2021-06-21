using RestSharp;


namespace spbgui.backend
{
    public class Request
    {
        public static IRestResponse<ApiClass> ApiRequest(string param)
        {
            var client = new RestClient("https://api.intellivoid.net");
            var req = new RestRequest($"spamprotection/v1/lookup?query={param}", Method.GET);
            req.AddHeader("User-Agent", "SpamProtection GUI");

            var data = client.Execute<ApiClass>(req);
            return data;
        }
    }
}
