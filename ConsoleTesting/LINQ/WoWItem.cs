using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public enum Category
    {
        Handwerkszeug, Waffe, Kleidung, Rüstung, Süßigkeit
    }

    class WoWItem
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int Price { get; set; }

        public static WoWItem[] GetItemList()
        {
            WoWItem[] temp = new WoWItem[]
            {
                new WoWItem() { Category = Category.Handwerkszeug, ID = "H01", Description = "Runenstoff", Price = 14 },
                new WoWItem() { Category = Category.Waffe, ID = "W01", Description = "Luft-Zauberstab", Price = 141 },
                new WoWItem() { Category = Category.Waffe, ID = "W02", Description = "Heiliger Stecken", Price = 1114 },
                new WoWItem() { Category = Category.Kleidung, ID = "K01", Description = "Lindwurmhaut", Price = 14 },
                new WoWItem() { Category = Category.Rüstung, ID = "R01", Description = "Elitedrachen-Stulpenhandschuhe", Price = 14 },
                new WoWItem() { Category = Category.Süßigkeit, ID = "S01", Description = "Geburtstagskuchen", Price = 14 },
                new WoWItem() { Category = Category.Süßigkeit, ID = "S02", Description = "Roter Kandis", Price = 14 },
                new WoWItem() { Category = Category.Kleidung, ID = "K02", Description = "Rekrutenhemd", Price = 14 },
                new WoWItem() { Category = Category.Handwerkszeug, ID = "H02", Description = "Dietrich", Price = 14 },
            };
            return temp;
        }

    }
}
