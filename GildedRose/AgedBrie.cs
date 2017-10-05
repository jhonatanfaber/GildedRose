namespace GildedRose{
    public class AgedBrie : GeneralItem{
        private string name;
        private int sellIn;
        private int quality;
        private int limitQuality;


        public AgedBrie(string name, int sellIn, int quality){
            this.name = name;
            this.sellIn = sellIn;
            this.quality = quality;
            limitQuality = 50;
        }

        public int updateQuality(){
            if(quality >= limitQuality) return quality;
            if(sellIn > 0){
                quality = quality + 1;
            } else{
                quality = quality + 2;
            }
            return quality;
        }
    }
}