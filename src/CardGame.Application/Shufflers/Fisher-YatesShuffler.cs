using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Application.Shufflers
{
    public class Fisher_YatesShuffler : IShuffler
    {
        public ICollection<T> Shuffle<T>(ICollection<T> collection) where T : class
        {
            Random r = new Random();
            IList<T> items = collection.ToList();
            for (int i = 0; i < items.Count - 1; i++)
            {
                int pos = r.Next(i, items.Count);
                T temp = items[i];
                items[i] = items[pos];
                items[pos] = temp;
            }
            return items;
        }
    }
}
