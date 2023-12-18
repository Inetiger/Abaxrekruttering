namespace Abaxrekruttering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Bil_1 = new Car("NF234567", 147, 200, Color.Grønn, LandVehicle.LettKjøretøy);
            Car Bil_2 = new Car("NF654321", 150, 195, Color.Blå, LandVehicle.LettKjøretøy);
            Plane Plane = new Plane("LN1234", 1000, 30, 2, 10, SkyVehicle.Jetfly);
            Boat Boat = new Boat("ABC123", 100, 30, 500);

            Bil_1.PrintInfoOfVehicle();
            Bil_2.PrintInfoOfVehicle();

            if (Bil_1 == Bil_2) Console.WriteLine("Bilene er lik");
            else Console.WriteLine("Bilene er ikke lik");

            Plane.PrintInfoOfVehicle();

            Plane.Movement();
            Bil_1.Movement();

            Boat.PrintInfoOfVehicle();
        }
    }
}

// Printe information om en (bil 1) med reg. nr NF234567, 147kw effekt, maksfart 200km/t, grønn farge av typen lett kjøretøy.
// * registration number * HorsePower * Makshastighet * Farge * Type.

// Printe informasjon om en annen bil (bil 2) med reg. nr NF654321, 150kw effekt, maksfart 195km/t, blå farge og av typen lett kjøretøy.
// * registration number * HorsePower * Makshastighet * Farge * Type.

// Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet.

// Printe informasjon om et fly med kjennetegn LN1234, 1000kw effekt, 30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly.
// * registration number * HorsePower * Vingebredde * Makslast * Egenvekt * Type.

// Konsollprogrammet skal be flyet om å fly og printe dette i konsollet.

// Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet.

// Printe informasjon om en båt med kjennetegn ABC123, 100kw effekt, maksfart på 30knop, 500kg bruttotonnasje.
// * registration number * HorsePower * Maksfart * Volum.