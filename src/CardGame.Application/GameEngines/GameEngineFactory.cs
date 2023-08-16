using CardGame.Application.GameEngines.Poker;
using CardGame.Application.Shufflers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Application.GameEngines
{
    public class GameEngineFactory
    {
        public IShuffler Shuffler { get; }
        public GameEngineFactory(IShuffler shuffler) {
            Shuffler = shuffler;
        }

        public PokerEngine CreatePokerEngine(string gameID)
        {
            return new PokerEngine(gameID,Shuffler);
        }


    }
}
