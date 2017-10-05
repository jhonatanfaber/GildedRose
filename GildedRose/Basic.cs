using System;

namespace GildedRose{
    public class Basic : GeneralItem{
        private string name;
        private int sellIn;
        private int quality;


        public Basic(string name, int sellIn, int quality){
            this.name = name;
            this.sellIn = sellIn;
            this.quality = quality;
        }

        public int updateQuality(){
            if(quality > 0){
                if(sellIn > 0){
                    quality = quality - 1;
                } else{
                    quality = quality - 2;
                }
            }
            if(quality < 0){ quality = 0; }
            return quality;
        }
    }
}