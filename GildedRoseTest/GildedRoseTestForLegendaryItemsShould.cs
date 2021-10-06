using csharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTest
{
    class GildedRoseTestForLegendaryItemsShould
    {
        [Test]
        [TestCase("Sulfuras, Hand of Ragnaros", 10, 45, 10, 45)]
        public void SellInAndQualityRemainsTheSameForLegendaryItems(string Name, int SellIn,
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
