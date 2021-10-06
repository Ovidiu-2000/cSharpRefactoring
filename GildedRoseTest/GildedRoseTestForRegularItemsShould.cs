using NUnit.Framework;
using System.Collections.Generic;
using csharp;
namespace GildedRoseTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("regular1", 20, 30, 19, 29)]
        [TestCase("regular2", 0, 0, -1, 0)]
        public void ReturnCorrectSellInAndQualityForRegularItemsWhenSellInIsPositiveOrZero(string Name, int SellIn, 
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
        [TestCase("regular1", -2, 10, -3, 8)]
        public void ReturnCorrectSellInAndQualityForRegularItemsWhenSellInNegative(string Name, int SellIn,
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
        [TestCase("regular1", -2, 1, -3, 0)]
        [TestCase("regular1", 3, 0, 2, 0)]
        public void NotDecreaseQualityUnderZeroForRegularItemsWhenSellInNegativeOrPositive(string Name, int SellIn,
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