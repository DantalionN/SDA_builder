using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA_builder.Model
{
    public enum PaintColor
    {
        Black,
        White
    }
    public class Paint
    {
        public PaintColor Color { get; set; }
        //public string Type { get; set; }
        //public bool Metallic { get; set; }

        public static Dictionary<PaintColor, decimal> Prices = new Dictionary<PaintColor, decimal>()
        {
           { PaintColor.Black, 2000 },
           { PaintColor.White, 1500 }
        };
    }
}
