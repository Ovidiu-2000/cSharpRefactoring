using csharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTest
{
    class GildedRoseCommonTestShould
    {
        [Test]
        [TestCase("Regular1", 15, 50, 14, 49)]
        [TestCase("Aged Brie", 15, 50, 14, 50)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 15, 50, 14, 50)]
        
        public void NotExceed50QualityForAllItemsExceptTheLegendaryOne(string Name, int SellIn,
            int Quality, int ExpectedSellIn, int ExpectedQuality)
        {
            IList<Item> items = new List<Item>()
            {
                new Item(){ Name = Name, SellIn = SellIn, Quality = Quality}
            };

            GildedRose gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            Assert.That(items[0].SellIn, Is.EqualTo(ExpectedSellIn));
            Assert.That(items[0].Quality, Is.EqualTo(ExpectedQuality));
        }
    }
}
