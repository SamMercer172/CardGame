using CardGame.Domain.Entities.Cards.StandardCards;
using CardGame.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Application.GameEngines.Poker
{
    public class PokerEngine
    {
        public Player Dealer { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<StandardCard> Deck { get; set; }
    }
}
