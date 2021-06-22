using System.Text.Json.Serialization;

namespace SPB.IntelliCore
{
	public sealed class SpbResult
	{
		[JsonPropertyName("private_telegram_id")]
		public string PrivateTelegramID { get; set; }
		
		[JsonPropertyName("entity_type")]
		public string EntityType { get; set; }

		[JsonPropertyName("attributes")]
		public Attributes Attributes { get; set; }

		[JsonPropertyName("language_prediction")]
		public LanguagePrediction LangPrediction { get; set; }

		[JsonPropertyName("spam_prediction")]
		public SpamPrediction SpamPrediction { get; set; }

		[JsonPropertyName("last_updated")]
		public int LastUpdated { get; set; }
	}
}

/*
type Results struct {
	// The private Telegram ID of the entity
	PrivateTelegramID string `json:"private_telegram_id"`

	// The entity type, can be user, bot, group, supergroup or channel
	EntityType string `json:"entity_type"`

	// The attributes of the entity, such as blacklist information and so on.
	Attributes *Attributes `json:"attributes"`

	// Information about the generalized language prediction
	LanguagePrediction *LanguagePrediction `json:"language_prediction"`

	// Information about the generalized spam prediction
	SpamPrediction *SpamPrediction `json:"spam_prediction"`

	// The Unix Timestamp of when this was last updated in the database
	LastUpdated int `json:"last_updated"`
}



*/