using RestSharp;
using SPB.Security;

namespace SPB.IntelliCore
{
	public static class Request
	{
		public static IRestResponse<IntelliSpb> ApiRequest(StrongString param)
        {
			var client = new RestClient("https://api.intellivoid.net");
            var req = new RestRequest($"spamprotection/v1/lookup?query={param.GetValue()}", Method.GET);
            req.AddHeader("User-Agent", "SpamProtection GUI");

            return client.Execute<IntelliSpb>(req);
        }
	}
}