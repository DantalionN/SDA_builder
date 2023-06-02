using System;
using System.Collections.Generic;

namespace SDA_builder.Model
{
    public enum EngineType
    {
        Electric,
        NotElectric
    }

    public class Engine
    {
        public EngineType Type { get; set; }
        //public int Power { get; set; }
        //public int Capacity { get; set; }
        //public int CylinderCount { get; set; }

        public static Dictionary<EngineType, decimal> Prices = new Dictionary<EngineType, decimal>()
        {
            { EngineType.Electric, 50000 },
            { EngineType.NotElectric, 40000 }
        };
    }
}