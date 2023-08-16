using CardGame.Domain.Entities.Cards.StandardCards;
using CardGame.Domain.Entities.Players;

namespace CardGame.Domain.Entities.GameStates
{
    public class PokerGameState : IGameState
    {
        public string GameType => this.GetType().Name;
        public Player Dealer { get; set; }
        public IDictionary<Player, ICollection<StandardCard>> PlayersHands { get; set; }
        public ICollection<StandardCard> Deck { get; set; }
        public ICollection<StandardCard> SharedCards { get; set; }
        public int Game { get; set; }
        public int Round { get; set; }

        public PokerGameState()
        {
            Dealer = new(0, "Dealer");
            PlayersHands = new Dictionary<Player, ICollection<StandardCard>>() { { Dealer, new List<StandardCard>() } };
            SharedCards = new List<StandardCard>();
            Deck = new List<StandardCard>();
            Game = 0;
            Round = 0;
        }
    }
}
