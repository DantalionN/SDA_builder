using SDA_builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA_builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Builder()
             .SetType(EngineType.Electric)
             .SetPaint(PaintColor.Black)
             .SetSeats(SeatMaterial.Leather)
             .SetTires(TireBranc.Michelin)
             .Build();

            Console.WriteLine(car.Price());
            Console.ReadKey();

        }
    }
}
