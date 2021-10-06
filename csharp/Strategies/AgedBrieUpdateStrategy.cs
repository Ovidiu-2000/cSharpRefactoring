using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Strategies
{
    class AgedBrieUpdateStrategy : IItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {   
            if (item.Quality < 50) item.Quality++;
            item.SellIn--;
        }
    }
}
