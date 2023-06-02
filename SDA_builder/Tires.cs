using System.Collections.Generic;

namespace SDA_builder.Model
{
    public enum TireBranc
    {
        Michelin,
        Goodyear
    }

    public class Tires
    {
        public TireBranc Brand { get; set; }
        //public int Diameter { get; set; }
        //public int Width { get; set; }
        //public int ProfileHeight { get; set; }

        public static Dictionary<TireBranc, decimal> Prices = new Dictionary<TireBranc, decimal>()
        {
           { TireBranc.Michelin, 1000 },
           { TireBranc.Goodyear, 800 }
        };
    }
}
