namespace SDA_builder.Model
{
    public class Car
    {
        public Engine Engine { get; set; }
        public Paint Paint { get; set; }
        public Seats Seats { get; set; }
        public Tires Tires { get; set; }

        public Car()
        {
            Engine = new Engine();
            Paint = new Paint();
            Seats = new Seats();
            Tires = new Tires();
        }

        public decimal Price()
        {
            decimal total = 0;

            total += Engine.Prices[Engine.Type];
            total += Paint.Prices[Paint.Color];
            total += Seats.Prices[Seats.Material];
            return total;
        }
    }
}



