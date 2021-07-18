using Newtonsoft.Json;

namespace spbgui.backend
{
    public class ApiClass
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("response_code")]
        public long ResponseCode { get; set; }

        [JsonProperty("results")]
        public Results Results { get; set; }

        [JsonProperty("error")]
        public ErrorClass ErrorError { get; set; }
    }

    public class ErrorClass
    {
        [JsonProperty("error_code")]
        public long ErrorCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Results
    {
        [JsonProperty("private_telegram_id")]
        public string PrivateTelegramId { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("language_prediction")]
        public LanguagePrediction LanguagePrediction { get; set; }

        [JsonProperty("spam_prediction")]
        public SpamPrediction SpamPrediction { get; set; }

        [JsonProperty("last_updated")]
        public long LastUpdated { get; set; }
    }

    public class Attributes
    {
        [JsonProperty("is_blacklisted")]
        public bool IsBlacklisted { get; set; }

        [JsonProperty("blacklist_flag")]
        public object BlacklistFlag { get; set; }

        [JsonProperty("blacklist_reason")]
        public object BlacklistReason { get; set; }

        [JsonProperty("original_private_id")]
        public object OriginalPrivateId { get; set; }

        [JsonProperty("is_potential_spammer")]
        public bool IsPotentialSpammer { get; set; }

        [JsonProperty("is_operator")]
        public bool IsOperator { get; set; }

        [JsonProperty("is_agent")]
        public bool IsAgent { get; set; }

        [JsonProperty("is_whitelisted")]
        public bool IsWhitelisted { get; set; }

        [JsonProperty("intellivoid_accounts_verified")]
        public bool IntellivoidAccountsVerified { get; set; }

        [JsonProperty("is_official")]
        public bool IsOfficial { get; set; }
    }

    public class LanguagePrediction
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("probability")]
        public double Probability { get; set; }
    }

    public class SpamPrediction
    {
        [JsonProperty("ham_prediction")]
        public double HamPrediction { get; set; }

        [JsonProperty("spam_prediction")]
        public double SpamPredictionSpamPrediction { get; set; }
    }
}
