using Newtonsoft.Json;
using System;

namespace GladiatorBeastGuide.Models
{
    /// <summary>
    /// The card image.
    /// </summary>
    public class CardImage
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The image url.
        /// </summary>
        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        /// <summary>
        /// The small image url.
        /// </summary>
        [JsonProperty("image_url_small")]
        public Uri ImageUrlSmall { get; set; }
    }
}