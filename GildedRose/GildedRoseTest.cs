using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRose{
    [TestFixture]
    public class GildedRoseTest{
        
        [SetUp] 
        public void SetUp(){
            
        }

        [Test]
        public void check_dexterity_Vests_sellIn_decreased_by_1(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "+5 Dexterity Vest",
                    SellIn = 9,
                    Quality = 19
                }
            };
           // GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getSellInOfItem();
            Assert.AreEqual(8, Items[0].SellIn);
        }
        
        [Test]
        public void check_dexterity_Vests_quality_decreased_by_1(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "+5 Dexterity Vest",
                    SellIn = 9,
                    Quality = 19
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getQualityOfBasicItem();
            Assert.AreEqual(18, Items[0].Quality);
        }
        
        [Test]
        public void check_dexterity_Vests_quality_decreases_double_when_date_has_passed(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "+5 Dexterity Vest",
                    SellIn = 0,
                    Quality = 10
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getQualityOfBasicItem();
            Assert.AreEqual(8, Items[0].Quality);
        }
        
        [Test]
        public void check_dexterity_Vests_quality_is_not_negative(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "+5 Dexterity Vest",
                    SellIn = -6,
                    Quality = 1
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getQualityOfBasicItem();
            Assert.AreEqual(0, Items[0].Quality);
        }

      
        [Test]
        public void check_age_bries_quality_increases_by_1(){
            IList<Item> Items = new List<Item>{
                new Item {Name = "Aged Brie",
                    SellIn = 2,
                    Quality = 0
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getQualityOfAgedBrie();
            Assert.AreEqual(1, Items[0].Quality);
        }

        [Test]
        public void check_age_bries_quality_increases_by_2_when_date_has_passed(){
            IList<Item> Items = new List<Item>{
                new Item {Name = "Aged Brie",
                    SellIn = 0,
                    Quality = 2
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getQualityOfAgedBrie();
            Assert.AreEqual(4, Items[0].Quality);
        }
        
        [Test]
        public void check_age_bries_quality_is_never_more_than_50(){
            IList<Item> Items = new List<Item>{
                new Item {Name = "Aged Brie",
                    SellIn = -24,
                    Quality = 50
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getQualityOfAgedBrie();
            Assert.AreEqual(50, Items[0].Quality);
        }
        
        [Test]
        public void check_sulfuras_quality_never_decreases(){
            IList<Item> Items = new List<Item>{
                new Item {Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = 0,
                    Quality = 80
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getSulfurasQuality();
            Assert.AreEqual(80, Items[0].Quality);
        }
        
        
        [Test]
        public void check_sulfuras_quality_never_decreases_when_date_has_passed(){
            IList<Item> Items = new List<Item>{
                new Item {Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = -1,
                    Quality = 80
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getSulfurasQuality();
            Assert.AreEqual(80, Items[0].Quality);
        }
        
        [Test]
        public void check_backstagePasses_quality_increases_by_1(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getBackstagePassesQuality();
            Assert.AreEqual(21, Items[0].Quality);
        }
        
        [Test]
        public void check_backstagePasses_quality_increases_by_2_when_10days_or_less(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 47
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getBackstagePassesQuality();
            Assert.AreEqual(49, Items[0].Quality);
        }
        
        [Test]
        public void check_backstagePasses_quality_increases_by_2_when_10days_or_less_and_doesnt_overpass_50(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getBackstagePassesQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }
        
        [Test]
        public void check_backstagePasses_quality_increases_by_3_when_5days_or_less(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 46
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getBackstagePassesQuality();
            Assert.AreEqual(49, Items[0].Quality);
        }
        
        [Test]
        public void check_backstagePasses_quality_increases_by_3_when_5days_or_less_and_doesnt_overpass_50(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 48
                },
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getBackstagePassesQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }
        
        [Test]
        public void check_backstagePasses_quality_decreases_to_0_when_date_has_passed(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 0,
                    Quality = 50
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getBackstagePassesQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }
        
        [Test]
        public void check_conjured_quality_decreases_by_2(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "Conjured Mana Cake",
                    SellIn = 3,
                    Quality = 6
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getQualityOfConjuredItem();
            Assert.AreEqual(4, Items[0].Quality);
        }
        
        [Test]
        public void check_conjured_quality_decreases_by_4_when_date_has_passed(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "Conjured Mana Cake",
                    SellIn = -1,
                    Quality = 6
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getQualityOfConjuredItem();
            Assert.AreEqual(2, Items[0].Quality);
        }
        

        [Test]
        public void check_conjured_quality_reaches_zero(){
            IList<Item> Items = new List<Item>{
                new Item{
                    Name = "Conjured Mana Cake",
                    SellIn = 3,
                    Quality = 1
                }
            };
            //GildedRose app = new GildedRose(Items);
            Data data = new Data(Items);
            data.getQualityOfConjuredItem();
            Assert.AreEqual(0, Items[0].Quality);
        }
        
    }
}
