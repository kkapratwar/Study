namespace LearningProject.DesignPatterns.FactoryPattern
{
    public class Car : IVehicle
    {
        public int NumberOfWheels()
        {
            return 4;
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
}
