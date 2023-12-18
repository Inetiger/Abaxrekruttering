namespace Abaxrekruttering
{
    internal class Car : Vehicle
    {
        public int Makshastighet { get; set; }
        public Color Color { get; set; }
        public LandVehicle LandVehicle { get; set; }

        public Car(string registration_number, int horsePower, int makshastighet, Color color, LandVehicle landVehicle)
        {
            base.Registration_number = registration_number;
            base.HorsePower = horsePower;
            Makshastighet = makshastighet;
            Color = color;
            LandVehicle = landVehicle;
        }

        public override void Movement()
        {
            Console.Write("Bilene ");
            base.Movement();
        }

        public override void PrintInfoOfVehicle()
        {
            Console.WriteLine($"{LandVehicle}, er {Color}, den har en maks hastighet på {Makshastighet}km/t med hele {HorsePower}kw og reg. nr {Registration_number}");
        }
    }
}
