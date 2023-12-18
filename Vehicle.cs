namespace Abaxrekruttering
{
    internal class Vehicle
    {
        public string Registration_number { get; set; }
        public int HorsePower { get; set; }

        public virtual void Movement()
        {
            Console.WriteLine("har flyttet seg");
        }

        public virtual void PrintInfoOfVehicle()
        {

        }
    }
}