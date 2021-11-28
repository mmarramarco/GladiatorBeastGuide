using GladiatorBeastGuide.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace GladiatorBeastGuide.Providers
{
    /// <summary>
    /// The YgoProDeck provider.
    /// </summary>
    public class YgoProDeckProvider : IYgoProDeckProvider
    {
        private const string YgoProDeckRoute = "https://db.ygoprodeck.com/api/v7/cardinfo.php";

        /// <inheritdoc/>
        public async Task<Card> Get(string name)
        {
            // var formattedName = name.Replace(" ", "%20");
            var nameFilter = $"?name={name}";
            var completeRoute = $"{YgoProDeckRoute}{nameFilter}";
            using var client = new HttpClient();
            var result = await client.GetAsync(completeRoute).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (!result.IsSuccessStatusCode)
            {
                throw new InvalidProgramException($"Something went wrong while calling YgoProDeck API: tried {completeRoute}, got status code '{result.StatusCode}':'{content}'");
            }

            var card = JsonConvert.DeserializeObject<YgoProDeckAnswer>(content).Data.First();
            return card;
        }

        /// <inheritdoc/>
        public async Task<List<Card>> GetAllGladiatorBeastCard()
        {
            const string ArchetypalFilter = "?archetype=Gladiator%20Beast";
            var completeRoute = $"{YgoProDeckRoute}{ArchetypalFilter}";
            using var client = new HttpClient();
            var result = await client.GetAsync(completeRoute).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (!result.IsSuccessStatusCode)
            {
                throw new InvalidProgramException($"Something went wrong while calling YgoProDeck API: got status code '{result.StatusCode}':'{content}'");
            }

            var cards = JsonConvert.DeserializeObject<YgoProDeckAnswer>(content).Data;
            return cards;
        }


        /// <summary>
        /// The ygo pro deck answer. 
        /// It's an array named "data", and it's kind of useless to make a separate class for it, so I'm just going to put one here.
        /// </summary>
        internal class YgoProDeckAnswer
        {
            /// <summary>
            /// The data.
            /// </summary>
            public List<Card> Data { get; set; }
        }
    }
}
