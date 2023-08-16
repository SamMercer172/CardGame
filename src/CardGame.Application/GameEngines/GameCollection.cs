using CardGame.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Application.GameEngines
{
    public class GameCollection
    {
        public ICollection<IGameEngine> Games;

        public GameCollection()
        {
            Games = new List<IGameEngine>();
        }

        public bool IsGameIdUsed(string gameId) => Games.Any(x => x.GameID == gameId);
        public IGameEngine GetGame(string gameId)
        {
            IGameEngine? game = Games.FirstOrDefault(x => x.GameID == gameId);
            if (game is null) throw new GameNotFoundException(gameId);
            return game;
        }

        public void AddGame(IGameEngine game)
        {
            if(IsGameIdUsed(game.GameID)) throw new GameIdInUseException(game.GameID);
            Games.Add(game);
        }
    }
}
