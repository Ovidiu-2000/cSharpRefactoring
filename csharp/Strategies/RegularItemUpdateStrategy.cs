﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class RegularItemUpdateStrategy : IItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            if (item.Quality > 0) item.Quality--;
            if (item.SellIn < 0)
            {
                if (item.Quality > 0) item.Quality--;
            }
            item.SellIn--;
        }
    }
}
