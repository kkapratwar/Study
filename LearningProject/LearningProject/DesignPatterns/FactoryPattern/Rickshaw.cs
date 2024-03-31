namespace LearningProject.DesignPatterns.FactoryPattern
{
    public class Rickshaw : IVehicle
    {
        public int NumberOfWheels()
        {
            return 3;
        }

        public string VehicleType()
        {
            return "Rickshaw";
        }
    }
}
