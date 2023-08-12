using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Application.Shufflers
{
    public interface IShuffler
    {
        ICollection<T> Shuffle<T>(ICollection<T> collection) where T : class;
    }
}
