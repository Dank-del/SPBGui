using System.Text.Json.Serialization;

namespace SPB.IntelliCore
{
	public sealed class SpamPrediction
	{
		[JsonPropertyName("ham_prediction")]
		public float HamPrediction { get; set; }
		[JsonPropertyName("spam_prediction")]
		public float Prediction { get; set; }
	}
}

/*
type SpamPrediction struct {
	// The probability (confidence) of this generalized ham
	// (not spam) prediction, if no prediction is
	// available then it will be zero
	HamPrediction float64 `json:"ham_prediction"`

	// The probability (confidence) of this generalized
	// spam prediction, if no prediction is available
	// then it will be zero
	SpamPrediction float64 `json:"spam_prediction"`
}
*/