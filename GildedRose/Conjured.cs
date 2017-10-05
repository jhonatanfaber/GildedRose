namespace GildedRose{
    public class Conjured : GeneralItem{
        private string name;
        private int sellIn;
        private int quality;


        public Conjured(string name, int sellIn, int quality){
            this.name = name;
            this.sellIn = sellIn;
            this.quality = quality;
        }

        public int updateQuality(){
            if(quality > 0){
                if(sellIn > 0){
                    quality = quality - 2;
                } else{
                    quality = quality - 4;
                }
            }
            if(quality < 0){ quality = 0; }
            return quality;
        }
    }
}