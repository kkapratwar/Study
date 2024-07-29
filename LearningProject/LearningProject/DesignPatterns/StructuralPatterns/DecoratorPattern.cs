using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.DesignPatterns.StructuralPatterns
{
    public abstract class Coffee
    {
        public abstract string GetDescritpion();
        public abstract float GetPrice();
    }

    public class PlainCoffee : Coffee
    {
        public override string GetDescritpion()
        {
            return "It's Plain Coffee";
        }

        public override float GetPrice()
        {
            return 1.0f;
        }
    }

    public abstract class CoffeeDecorator : Coffee
    {
        protected Coffee coffee;

        public void SetCoffee(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public override string GetDescritpion()
        {
            if (coffee != null)
            {
                return coffee.GetDescritpion();
            }

            return string.Empty;
        }

        public override float GetPrice()
        {
            if (coffee != null)
            {
                return coffee.GetPrice();
            }

            return default;
        }
    }

    public class MilkCoffeeDecorator : CoffeeDecorator
    {
        public override string GetDescritpion()
        {
            return base.GetDescritpion() + ", Milk added to coffee";
        }

        public override float GetPrice()
        {
            return base.GetPrice() + 0.5f;
        }
    }

    public class SugarCoffeeDecorator : CoffeeDecorator
    {
        public override string GetDescritpion()
        {
            return base.GetDescritpion() + ", Sugar added to coffee";
        }

        public override float GetPrice()
        {
            return base.GetPrice() + 1.0f;
        }
    }

    public class DecoratorPattern
    {
        public DecoratorPattern()
        {
            PlainCoffee plainCoffee = new PlainCoffee();
            Console.WriteLine($"Description - {plainCoffee.GetDescritpion()}. Price - ${plainCoffee.GetPrice()}");

            MilkCoffeeDecorator milkCoffeeDecorator = new MilkCoffeeDecorator();
            milkCoffeeDecorator.SetCoffee(plainCoffee);
            Console.WriteLine($"Description - {milkCoffeeDecorator.GetDescritpion()}. Price - ${milkCoffeeDecorator.GetPrice()}");

            SugarCoffeeDecorator sugarCoffeeDecorator = new SugarCoffeeDecorator();
            sugarCoffeeDecorator.SetCoffee(milkCoffeeDecorator);
            Console.WriteLine($"Description - {sugarCoffeeDecorator.GetDescritpion()}. Price - ${sugarCoffeeDecorator.GetPrice()}");
        }
    }
}
