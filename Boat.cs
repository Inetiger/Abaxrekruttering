namespace Abaxrekruttering
{
    internal class Boat : Vehicle
    {
        public int Makshastighet { get; set; }
        public int Bruttotonnasje { get; set; }

        public Boat(string registration_number, int horsePower, int makshastighet, int bruttotonnasje)
        {
            base.Registration_number = registration_number;
            base.HorsePower = horsePower;
            Makshastighet = makshastighet;
            Bruttotonnasje = bruttotonnasje;
        }

        public override void Movement()
        {
            Console.Write("Båten ");
            base.Movement();
        }

        public override void PrintInfoOfVehicle()
        {
            Console.WriteLine($"Denne båten har et volum på {Bruttotonnasje}kg, den har en maks hastighet på {Makshastighet}knop med hele {HorsePower}kw og reg. nr {Registration_number}");
        }
    }
}
