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
        /// <returns></returns>
        public Task<List<Card>> GetAllGladiatorBeastCard();
    }
}
