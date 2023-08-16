using CardGame.Application.DeckGenerators;
using CardGame.Application.Shufflers;
using CardGame.Domain.Entities.Cards.StandardCards;
using CardGame.Domain.Entities.Enums;
using CardGame.Domain.Entities.GameStates;

namespace CardGame.Application.GameEngines.Poker
{
    public class PokerEngine : IGameEngine
    {
        public string GameID { get; }

        public GameTypes GameType => GameTypes.Poker;

        private readonly IShuffler _shuffler;

        private PokerGameState _gameState;

        public PokerEngine(string gameID, IShuffler shuffler)
        {
            GameID = gameID;
            _shuffler = shuffler;
            _gameState = new();
            _gameState.Deck = StandardCardDeckGenerator.GenerateDecks(3);
        }

        public void StartGame()
        {
            _gameState.Deck = _shuffler.Shuffle(_gameState.Deck);
        }
    }
}
