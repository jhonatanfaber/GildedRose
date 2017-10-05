namespace GildedRose{
    public class BackStage : GeneralItem{
        private string name;
        private int sellIn;
        private int quality;
        private readonly int limitQuality;


        public BackStage(string name, int sellIn, int quality){
            this.name = name;
            this.sellIn = sellIn;
            this.quality = quality;
            limitQuality = 50;
        }

        public int updateQuality(){
            const int limitTen = 10;
            const int limitFive = 5;
            if(sellIn <= 0){
                quality = 0;
            } else{
                if(quality < limitQuality){
                    if(sellIn > limitFive){
                        quality = quality + 1;
                    } else if(sellIn <= limitTen && sellIn > limitFive){
                        quality = quality + 2;
                    } else{
                        quality = quality + 3;
                    }
                }
                if(quality > 50){
                    quality = 50;
                }
            }
            return quality;
        }
    }
}