namespace LearningProject.DesignPatterns.FactoryPattern
{
    public class Bike : IVehicle
    {
        public int NumberOfWheels()
        {
            return 2;
        }

        public string VehicleType()
        {
            return "Bike";
        }
    }
}
