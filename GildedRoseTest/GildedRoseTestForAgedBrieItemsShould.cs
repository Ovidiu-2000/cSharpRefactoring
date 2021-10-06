using csharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTest
{
    class GildedRoseTestForAgedBrieItemsShould
    {
        [Test]
        [TestCase("Aged Brie", 15, 45, 14, 46)]
        public void IncreaseQualityForAgedBrieItems(string Name, int SellIn,
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

        [Test]
        [TestCase("Aged Brie", 15, 50, 14, 50)]
        public void NotExceed50QualityForAgedBrieItems(string Name, int SellIn,
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
