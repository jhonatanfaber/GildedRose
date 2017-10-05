using NUnit.Framework;

namespace GildedRose{   
    
    [TestFixture] 
    public class GildedRoseTest{
        
        [Test] 
        public void check_dexterity_Vests_quality_decreased_by_1(){
            Item items = new Item{
                Name = "+5 Dexterity Vest",
                SellIn = 9,
                Quality = 19
            };
            Basic basic = new Basic(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(18, basic.updateQuality());
        }

        [Test]
        public void check_dexterity_Vests_quality_decreases_double_when_date_has_passed(){
            Item items = new Item{
                Name = "+5 Dexterity Vest",
                SellIn = 0,
                Quality = 10
            };
            Basic basic = new Basic(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(8, basic.updateQuality());
        }

        [Test]
        public void check_dexterity_Vests_quality_is_not_negative(){
             Item items = new Item{
                Name = "+5 Dexterity Vest",
                SellIn = -6,
                Quality = 1
            };
            Basic basic = new Basic(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(0, basic.updateQuality());
        }


        [Test] 
        public void check_age_bries_quality_increases_by_1(){
            Item items = new Item(){
                Name = "Aged Brie",
                SellIn = 2,
                Quality = 0
            };
            AgedBrie agedBrie = new AgedBrie(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(1, agedBrie.updateQuality());
        }

        [Test]
        public void check_age_bries_quality_increases_by_2_when_date_has_passed(){
            Item items = new Item(){
                Name = "Aged Brie",
                SellIn = 0,
                Quality = 2
            };
            AgedBrie agedBrie = new AgedBrie(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(4, agedBrie.updateQuality());
        }

        [Test]
        public void check_age_bries_quality_is_never_more_than_50(){
            Item items = new Item(){
                Name = "Aged Brie",
                SellIn = -24,
                Quality = 50
            };
            AgedBrie agedBrie = new AgedBrie(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(50, agedBrie.updateQuality());
        }

        [Test] 
        public void check_sulfuras_quality_never_decreases(){
            Item items = new Item(){
                Name = "Sulfuras, Hand of Ragnaros",
                SellIn = 0,
                Quality = 80
            };
            Sulfuras sulfuras = new Sulfuras(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(80, sulfuras.updateQuality());
        }

        // ?
        [Test] 
        public void check_sulfuras_quality_never_decreases_when_date_has_passed(){
            Item items = new Item(){
                Name = "Sulfuras, Hand of Ragnaros",
                SellIn = -1,
                Quality = 80
            };
            Sulfuras sulfuras = new Sulfuras(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(80, sulfuras.updateQuality());
        }

        [Test]
        public void check_backstagePasses_quality_increases_by_1(){
            Item items = new Item(){
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            };
            BackStage backStage = new BackStage(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(21, backStage.updateQuality());
        }

        [Test] public void check_backstagePasses_quality_increases_by_2_when_10days_or_less(){
            Item items = new Item(){
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 47
            };
            BackStage backStage = new BackStage(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(49, backStage.updateQuality());
        }

        [Test] 
        public void check_backstagePasses_quality_increases_by_2_when_10days_or_less_and_doesnt_overpass_50(){
            Item items = new Item(){
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 49
            };
            BackStage backStage = new BackStage(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(50, backStage.updateQuality());
        }

        [Test]
        public void check_backstagePasses_quality_increases_by_3_when_5days_or_less(){
            Item items = new Item(){
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 46
            };
            BackStage backStage = new BackStage(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(49, backStage.updateQuality());
        }

        [Test]
        public void check_backstagePasses_quality_increases_by_3_when_5days_or_less_and_doesnt_overpass_50(){
            Item items = new Item(){
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 48
            };
            BackStage backStage = new BackStage(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(50, backStage.updateQuality());
        }

        [Test] 
        public void check_backstagePasses_quality_decreases_to_0_when_date_has_passed(){
            Item items = new Item(){
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 0,
                Quality = 50
            };
            BackStage backStage = new BackStage(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(0, backStage.updateQuality());
        }

        [Test]
        public void check_conjured_quality_decreases_by_2(){
            Item items = new Item(){
                Name = "Conjured Mana Cake",
                SellIn = 3,
                Quality = 6
            };
            Conjured conjuredItem = new Conjured(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(4, conjuredItem.updateQuality());
        }

        [Test] 
        public void check_conjured_quality_decreases_by_4_when_date_has_passed(){
            Item items = new Item(){
                Name = "Conjured Mana Cake",
                SellIn = -1,
                Quality = 6
            };
            Conjured conjuredItem = new Conjured(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(2, conjuredItem.updateQuality());
        }


        [Test] 
        public void check_conjured_quality_reaches_zero(){
            Item items = new Item(){
                Name = "Conjured Mana Cake",
                SellIn = 3,
                Quality = 1
            };
            Conjured conjuredItem = new Conjured(items.Name, items.SellIn, items.Quality);
            Assert.AreEqual(0, conjuredItem.updateQuality());
        }
    }
}