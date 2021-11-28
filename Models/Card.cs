using Newtonsoft.Json;
using System.Collections.Generic;

namespace GladiatorBeastGuide.Models
{
    /// <summary>
    /// The card.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type.
        /// </summary>
        /// <example>Normal Monster, Fusion Monster, Spell Card...</example>
        public string Type { get; set; }

        /// <summary>
        /// The description or effect of a card.
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// The Atk value, if any.
        /// </summary>
        public int? Atk { get; set; }

        /// <summary>
        /// The Def value, if any.
        /// </summary>
        public int? Def { get; set; }

        /// <summary>
        /// The level or rank of the card.
        /// </summary>
        public int? Level { get; set; }

        /// <summary>
        /// The card race, officially called type (Spellcaster, Field, Counter...).
        /// </summary>
        public string Race { get; set; }

        /// <summary>
        /// The attribute of a card.
        /// </summary>
        public string Attribute { get; set; }

        /// <summary>
        /// The archetype.
        /// </summary>
        public string Archetype { get; set; }

        /// <summary>
        /// The scale of a card, if it's a pendulum card.
        /// </summary>
        public int? Scale { get; set; }

        /// <summary>
        /// The link value if it's a link monster.
        /// </summary>
        public int? LinkVal { get; set; }

        /// <summary>
        /// The link markers.
        /// </summary>
        public List<string> LinkMarkers { get; set; }

        /// <summary>
        /// The card set.
        /// </summary>
        [JsonProperty("card_sets")]
        public List<CardSet> Sets { get; set; }

        /// <summary>
        /// The card images.
        /// </summary>
        [JsonProperty("card_images")]
        public List<CardImage> Images { get; set; }

        /// <summary>
        /// The card prices.
        /// </summary>
        [JsonProperty("card_prices")]
        public List<CardPrice> Prices { get; set; }

        /// <summary>
        /// The banlist information.
        /// </summary>
        [JsonProperty("banlist_info")]
        public BanlistInformation BanlistInformation { get; set; }

        /// <summary>
        /// The additional information we wish to display to a monster.
        /// That's where we'll put most of the the card by card handwritten information.
        /// </summary>
        public AdditionalInformation AdditionalInformation { get; set; }
    }
}
