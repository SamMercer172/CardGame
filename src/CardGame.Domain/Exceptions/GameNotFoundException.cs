using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Domain.Exceptions
{
    public class GameNotFoundException : Exception
    {
        public GameNotFoundException(string gameId):base($"GameID:\"{gameId}\" was not found.")
        {
        }
    }
}
