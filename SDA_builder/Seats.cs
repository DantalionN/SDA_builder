using System.Collections.Generic;

namespace SDA_builder.Model
{
    public enum SeatMaterial
    {
        Leather,
        SyntheticMaterial
    }

    public class Seats
    {
        public SeatMaterial Material { get; set; }
        //public bool Heated { get; set; }
        // public int AdjustmentCount { get; set; }

        public static Dictionary<SeatMaterial, decimal> Prices = new Dictionary<SeatMaterial, decimal>()
        {
            { SeatMaterial.Leather, 3000 },
            { SeatMaterial.SyntheticMaterial, 2000 }
        };
    }

}
