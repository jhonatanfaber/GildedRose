using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRose{
    public class Data{
        private IList<Item> items;
        private int limitQuality;

        public Data(IList<Item> items){
            this.items = items;
            limitQuality = 50;
        }

        public void getQualityOfBasicItem(){
            for (int i = 0; i < items.Count; i++){
                if(items[i].Quality > 0){
                    if(items[i].SellIn > 0){
                        items[i].Quality = items[i].Quality - 1;
                    } else{
                        items[i].Quality = items[i].Quality - 2;
                    }
                }
            }
            if(items[0].Quality < 0){ items[0].Quality = 0; }
        }

        public void getQualityOfConjuredItem(){
            for (int i = 0; i < items.Count; i++){
                if(items[i].Quality > 0){
                    if(items[i].SellIn > 0){
                        items[i].Quality = items[i].Quality - 2;
                    } else{
                        items[i].Quality = items[i].Quality - 4;
                    }
                }
            }
            if(items[0].Quality < 0){ items[0].Quality = 0; }
        }

        public void getSellInOfItem(){
            for (int i = 0; i < items.Count; i++){
                items[i].SellIn = items[i].SellIn - 1;
            }
        }

        public void getQualityOfAgedBrie(){
            for (int i = 0; i < items.Count; i++){
                if(items[i].Quality < limitQuality){
                    if(items[i].SellIn > 0){
                        items[i].Quality = items[i].Quality + 1;
                    } else{
                        items[i].Quality = items[i].Quality + 2;
                    }
                }
            }
        }

        public int getSulfurasQuality(){
            return items[0].Quality;
        }

        public void getBackstagePassesQuality(){
            int limitTen = 10;
            int limitFive = 5;
            if(items[0].SellIn <= 0){
                items[0].Quality = 0;
            } else{
                for (int i = 0; i < items.Count; i++){
                    if(items[i].Quality < limitQuality){
                        if(items[i].SellIn > limitTen){
                            items[i].Quality = items[i].Quality + 1;
                        } else if(items[i].SellIn <= limitTen && items[i].SellIn > limitFive){
                            items[i].Quality = items[i].Quality + 2;
                        } else{
                            items[i].Quality = items[i].Quality + 3;
                        }
                    }
                }
                if(items[0].Quality > 50){
                    items[0].Quality = 50;
                }
            }
        }
    }
}