using System.Text.Json.Serialization;

namespace SPB.IntelliCore
{
	public sealed class Attributes
	{
		[JsonPropertyName("is_blacklisted")]
		public bool IsBlacklisted { get; set; }

		[JsonPropertyName("blacklist_flag")]
		public string BlacklistFlag { get; set; }

		[JsonPropertyName("blacklist_reason")]
		public string BlacklistReason { get; set; }

		[JsonPropertyName("original_private_id")]
		public string OriginalPrivateID { get; set; }

		[JsonPropertyName("is_potential_spammer")]
		public bool IsPotentialSpammer { get; set; }

		[JsonPropertyName("is_operator")]
		public bool IsOperator { get; set; }

		[JsonPropertyName("is_agent")]
		public bool IsAgent { get; set; }

		[JsonPropertyName("is_whitelisted")]
		public bool IsWhitelisted { get; set; }

		[JsonPropertyName("intellivoid_accounts_verified")]
		public bool IntellivoidAccountsVerified { get; set; }
		
		[JsonPropertyName("is_official")]
		public bool IsOfficial { get; set; }
	}
}

/*

type Attributes struct {

	// Indicates if this entity was blacklisted by a operator or agent.
	IsBlacklisted bool `json:"is_blacklisted"`

	// If the target is blacklisted, the blacklist flag will be
	// available otherwise it will be an empty string.
	BlacklistFlag string `json:"blacklist_flag"`

	// If the target is blacklisted, a user friendly message
	// of the blacklist flag will be available otherwise
	// it will be an empty string
	BlacklistReason string `json:"blacklist_reason"`

	// If the target was blacklisted for 0xEVADE then the
	// original private telegram ID (ptid) will be available,
	// otherwise it will be an empty string
	OriginalPrivateID string `json:"original_private_id"`

	// Indicates if SpamProtection believes that
	// this user may be a potential spammer based on past activities
	IsPotentialSpammer bool `json:"is_potential_spammer"`

	// Indicates if this user is an operator for SpamProtectionBot
	IsOperator bool `json:"is_operator"`

	// Indicates if this user is an agent that automatically
	// reports spam to SpamProtectionBot (Userbot Agent)
	IsAgent bool `json:"is_agent"`

	// Indicates if this user is whitelisted and
	// cannot be blacklisted or seen as a potential spammer
	IsWhitelisted bool `json:"is_whitelisted"`

	// Indicates if this user has verified their
	// Telegram Account with Intellivoid Accounts
	IntellivoidAccountsVerified bool `json:"intellivoid_accounts_verified"`

	// Indicates if this entity is deemed
	// official by Intellivoid Technologies
	IsOfficial bool `json:"is_official"`
}


*/