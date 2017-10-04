namespace GildedRose{
    public class Item{ // do not alter the Item class or Items property 
        public string Name { get; set; }
        public int SellIn { get; set; }//  number of days we have to sell the item
        public int Quality { get; set; } //  how valuable the item is
        // At the end of each day our system lowers both values for every item
    }
    
    /**
    GAME RULES:
    
    Once the sell by date has passed, Quality degrades twice as fast
    The Quality of an item is never negative
    “Aged Brie” actually increases in Quality the older it gets
    The Quality of an item is never more than 50
    “Sulfuras”, being a legendary item, never has to be sold or decreases in Quality
    “Backstage passes”, like aged brie, increases in Quality as its SellIn value approaches;
        Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
        Quality drops to 0 after the concert
        
     Your task: “Conjured” items degrade in Quality twice as fast as normal items
     
     Just for clarification, an item can never have its Quality increase above 50, however “Sulfuras” 
     is a legendary item and as such its Quality is 80 and it never alters.

    */
}
