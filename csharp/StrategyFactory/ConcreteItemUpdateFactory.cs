using csharp.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.IStrategyFactory
{
    class ConcreteItemUpdateFactory : IItemUpdateFactory
    {
        public IItemUpdateStrategy CreateStrategy(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrieUpdateStrategy();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePassesUpdateStrategy();
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryUpdateStrategy();
                case "Conjured Mana Cake":
                    return new ConjuredUpdateStrategy();
                default:
                    return new RegularItemUpdateStrategy();
            }
        }
    }
}
