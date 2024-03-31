namespace LearningProject.DesignPatterns.FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string name)
        {
            switch (name)
            {
                case "bike":
                    return new Bike();
                case "car":
                    return new Car();
                case "rickshaw":
                    return new Rickshaw();
                default:
                    return new NoVehicle();
            }
        }
    }
}
