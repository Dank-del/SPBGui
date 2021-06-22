using System.Text.Json.Serialization;

namespace SPB.IntelliCore
{
	public sealed class IntelliSpb
	{
		[JsonPropertyName("success")]
		public bool Success { get; set; }
		[JsonPropertyName("response_code")]
		public int ResponseCode { get; set; }
		[JsonPropertyName("results")]
		public SpbResult Results { get; set; }
		[JsonPropertyName("error")]
		public SpbError Error { get; set; }
	}
}

/*type APIResponse struct {
	Success      bool     `json:"success"`
	ResponseCode int      `json:"response_code"`
	Results      *Results `json:"results"`
	Error        *Error   `json:"error"`
}
*/