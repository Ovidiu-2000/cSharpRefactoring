using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Strategies
{
    class LegendaryUpdateStrategy : IItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            item.Quality = -1;
            return;
        }
    }
}
