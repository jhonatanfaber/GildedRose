namespace GildedRose{
    public class Sulfuras{
        private string name;
        private int sellIn;
        private int quality;


        public Sulfuras(string name, int sellIn, int quality){
            this.name = name;
            this.sellIn = sellIn;
            this.quality = quality;
        }
        
        public int updateQuality(){
            return quality;
        }
    }
}