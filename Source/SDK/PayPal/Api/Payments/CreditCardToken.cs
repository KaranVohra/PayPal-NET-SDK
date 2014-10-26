using Newtonsoft.Json;

namespace PayPal.Api.Payments
{
    public class CreditCardToken
    {
        /// <summary>
        /// ID of a previously saved Credit Card resource using /vault/credit-card API.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_card_id")]
        public string credit_card_id { get; set; }

        /// <summary>
        /// The unique identifier of the payer used when saving this credit card using /vault/credit-card API.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payer_id")]
        public string payer_id { get; set; }

        /// <summary>
        /// Last 4 digits of the card number from the saved card.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "last4")]
        public string last4 { get; set; }

        /// <summary>
        /// Type of the Card (eg. visa, mastercard, etc.) from the saved card. Please note that the values are always in lowercase and not meant to be used directly for display.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string type { get; set; }

        /// <summary>
        /// card expiry month from the saved card with value 1 - 12
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expire_month")]
        public int expire_month { get; set; }

        /// <summary>
        /// 4 digit card expiry year from the saved card
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expire_year")]
        public int expire_year { get; set; }

        /// <summary>
        /// Converts the object to JSON string
        /// </summary>
        public virtual string ConvertToJson()
        {
            return JsonFormatter.ConvertToJson(this);
        }
    }
}
