using System.Text.Json.Serialization;

namespace SPB.IntelliCore
{
	public sealed class LanguagePrediction
	{
		[JsonPropertyName("language")]
		public string Language { get; set; }

		[JsonPropertyName("probability")]
		public float Probability { get; set; }
	}
}

/*

type LanguagePrediction struct {
	// The ISO 639-1 language code predicted by SpamProtectionBot,
	// if no prediction is available then it will be
	// an empty string
	Language string `json:"language"`

	// The probability (confidence) of this generalized
	// language prediction, if no prediction is available
	// then it will be zero
	Probability float64 `json:"probability"`
}


*/