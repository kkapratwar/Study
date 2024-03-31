namespace LearningProject.DesignPatterns.FactoryPattern
{
    public class NoVehicle : IVehicle
    {
        public int NumberOfWheels()
        {
            return 0;
        }

        public string VehicleType()
        {
            return "Invalid Type";
        }
    }
}
