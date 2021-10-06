using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.IStrategyFactory
{
    interface IItemUpdateFactory
    {
        IItemUpdateStrategy CreateStrategy(Item item);
    }
}
