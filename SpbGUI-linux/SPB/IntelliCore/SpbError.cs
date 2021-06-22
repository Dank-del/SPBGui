using System.Text.Json.Serialization;

namespace SPB.IntelliCore
{
	public sealed class SpbError
	{
		[JsonPropertyName("error_code")]
		public int ErrorCode { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("message")]
		public string Message { get; set; }
	}
}

/*

type Error struct {
	ErrorCode int    `json:"error_code"`
	Type      string `json:"type"`
	Message   string `json:"message"`
}


*/