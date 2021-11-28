using GladiatorBeastGuide.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GladiatorBeastGuide.Providers
{
    /// <summary>
    /// The YgoProDeck provider.
    /// </summary>
    public interface IYgoProDeckProvider
    {
        /// <summary>
        /// Get all the gladiator beast cards.
        /// </summary>
        /// <returns>A list of card.</returns>
        public Task<List<Card>> GetAllGladiatorBeastCard();

        /// <summary>
        /// Gets information about the given card.
        /// </summary>
        /// <param name="name">The name of the card.</param>
        /// <returns>The card information.</returns>
        public Task<Card> Get(string name);
    }
}
