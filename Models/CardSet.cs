using Newtonsoft.Json;

namespace GladiatorBeastGuide.Models
{
    /// <summary>
    /// The card set.
    /// </summary>
    public class CardSet
    {
        /// <summary>
        /// The name.
        /// </summary>
        [JsonProperty("set_name")]
        public string Name { get; set; }

        /// <summary>
        /// The code.
        /// </summary>
        [JsonProperty("set_code")]
        public string Code { get; set; }

        /// <summary>
        /// The rarity.
        /// </summary>
        [JsonProperty("set_rarity")]
        public string Rarity { get; set; }

        /// <summary>
        /// The rarity code.
        /// </summary>
        [JsonProperty("set_rarity_code")]
        public string RarityCode { get; set; }

        /// <summary>
        /// The price.
        /// </summary>
        [JsonProperty("set_price")]
        public string Price { get; set; }
    }
}