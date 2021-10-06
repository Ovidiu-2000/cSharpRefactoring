using csharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTest
{
    class GildedRoseTestForBackstagePassesItemsShould
    {
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 20, 40, 19, 41)]
        public void ReturnCorrectSellInAndQualityForBackstagePassesItemsWhenMoreThanOrEqualThan10DaysLeft(string Name, int SellIn,
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

        [TestCase("Backstage passes to a TAFKAL80ETC concert", 7, 40, 6, 42)]
        public void ReturnCorrectSellInAndQualityForBackstagePassesItemsWhenLessOrEqualThan10DaysLeftButMoreThanOrEqual5
            (string Name, 
            int SellIn, int Quality, int ExpectedSellIn, int ExpectedQuality)
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

        [TestCase("Backstage passes to a TAFKAL80ETC concert", 4, 40, 3, 43)]
        public void ReturnCorrectSellInAndQualityForBackstagePassesItemsWhenLessOrEqualThan5DaysLeft(string Name,
            int SellIn, int Quality, int ExpectedSellIn, int ExpectedQuality)
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
