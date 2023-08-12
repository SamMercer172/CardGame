using CardGame.Domain.Entities.Cards.StandardCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Application.DeckGenerators
{
    public static class StandardCardDeckGenerator
    {
        public static ICollection<StandardCard> GenerateDecks(int numberOfDecks)
        {
            List<StandardCard> cards = new List<StandardCard>();
            for(int i = 0; i < numberOfDecks; i++)
            {
               cards.AddRange(Enum.GetValues<Suit>().SelectMany(x => Enum.GetValues<Face>(), (suit, face) => new StandardCard(suit, face)));
            }

            return cards;
        }
    }
}
