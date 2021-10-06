using csharp.IStrategyFactory;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        IItemUpdateFactory _itemUpdateFactory;
        IItemUpdateStrategy _itemUpdateStrategy;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
            _itemUpdateFactory = new ConcreteItemUpdateFactory();
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                _itemUpdateStrategy = _itemUpdateFactory.CreateStrategy(Items[i]);
                _itemUpdateStrategy.UpdateItem(Items[i]);
            }
        }
    }
}
