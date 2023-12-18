namespace Abaxrekruttering
{
    internal class Plane : Vehicle
    {
        public int Vingespenn { get; set; }
        public int Lasteevne { get; set; }
        public int Egenvekt { get; set; }
        public SkyVehicle Type { get; set; }

        public Plane(string registration_number, int horsePower, int vingespenn, int lasteevne, int egenvekt, SkyVehicle type)
        {
            base.Registration_number = registration_number;
            base.HorsePower = horsePower;
            Vingespenn = vingespenn;
            Lasteevne = lasteevne;
            Egenvekt = egenvekt;
            Type = type;
        }

        public override void Movement()
        {
            Console.Write("Flyet ");
            base.Movement();
        }

        public override void PrintInfoOfVehicle()
        {
            Console.WriteLine($"{Type} har en egenvekt på {Egenvekt} tonn, du kan laste hele {Lasteevne}kg og en vingespenn på {Vingespenn}m. Med hele {HorsePower}kw og reg. nr {Registration_number}");
        }
    }
}
