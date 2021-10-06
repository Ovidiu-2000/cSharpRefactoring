using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Strategies
{
    class ConjuredUpdateStrategy : IItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {        
            if (item.SellIn > 0)
                item.SellIn--;
            if (item.SellIn <= 0)
                item.Quality -= 2;
            item.Quality -= 2;
        }
    }
}
