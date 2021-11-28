namespace GladiatorBeastGuide.Models
{
    /// <summary>
    /// The banlist information.
    /// </summary>
    public class BanlistInformation
    {
        /// <summary>
        /// The TCG banlist status.
        /// </summary>
        public string BanTcg { get; set; }

        /// <summary>
        /// The OCG banlist status.
        /// </summary>
        public string BanOcg { get; set; }

        /// <summary>
        /// The Goat banlist status.
        /// </summary>
        public string BanGoat { get; set; }
    }
}