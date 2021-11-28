namespace GladiatorBeastGuide.Models
{
    /// <summary>
    /// The card price. This is the lowest price found across multiple versions of that card.
    /// </summary>
    public class CardPrice
    {
        /// <summary>
        /// The card market price.
        /// </summary>
        public string CardMarketPrice { get; set; }

        /// <summary>
        /// The cool stuff inc price.
        /// </summary>
        public string CoolStuffIncPrice { get; set; }

        /// <summary>
        /// The TCG Player price.
        /// </summary>
        public string TcgPlayerPrice { get; set; }

        /// <summary>
        /// The ebay price.
        /// </summary>
        public string EbayPrice { get; set; }

        /// <summary>
        /// The amazon price.
        /// </summary>
        public string AmazonPrice { get; set; }
    }
}