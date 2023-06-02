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

        public decimal Price() => Engine.Prices[Engine.Type] + Paint.Prices[Paint.Color] + Seats.Prices[Seats.Material];
        
    }
}



