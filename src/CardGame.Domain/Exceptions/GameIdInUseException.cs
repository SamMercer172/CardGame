using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Domain.Exceptions
{
    public class GameIdInUseException : Exception
    {
        public GameIdInUseException(string gameId) : base($"GameID:\"{gameId}\" is already in use.")
        {
        }
    }
}
