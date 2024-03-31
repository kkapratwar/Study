namespace LearningProject.DesignPatterns.AbstractFactoryPattern
{
    public interface ICar
    {
        void GetDetails();
    }

    public interface IBike
    {
        void GetDetails();
    }

    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("It's Regular Car!");
        }
    }

    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("It's Sports Car!");
        }
    }

    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("It's Regular Bike!");
        }
    }

    public class SportsBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("It's Sports Bike!");
        }
    }

    public interface IVehicleFactory
    {
        ICar CreateCar();
        IBike CreateBike();
    }

    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }

        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }

    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportsBike();
        }

        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }
}
