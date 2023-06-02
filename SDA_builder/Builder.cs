using SDA_builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA_builder
{
    public class Builder
    {
        private Car car;

        public Builder()
        {
            car = new Car();
        }

        public Builder SetType(EngineType type)
        {
            car.Engine.Type = type;
            return this;
        }

        public Builder SetPaint(PaintColor color)
        {
            car.Paint.Color = color;
            return this;
        } 

        public Builder SetTires(TireBranc brand)
        {
            car.Tires.Brand = brand;
            return this;
        }

        public Builder SetSeats(SeatMaterial material)
        {
            car.Seats.Material = material;
            return this;
        }

        public Car Build()
        {
            return car;
        }
    }
}

