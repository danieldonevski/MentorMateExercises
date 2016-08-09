using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary
{
    public enum cars { AUDI, BMW}
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory facotry = null;
            bool rightCommand = true;
            while (rightCommand)
            {
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "audi":
                        facotry = new AudiFactory();
                        rightCommand = false;
                        break;
                    case "bmw":
                        facotry = new BMWFactory();
                        rightCommand = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Command");
                        break;
                }
            }


            ICarFactory factory = LoadFactory(facotry);

            var car = factory.CreateLuxaryCar();
            Console.WriteLine(car.ToString());

            car = factory.CreateSportsCar();
            Console.WriteLine(car.ToString());

            car = factory.CreateEconomyCar();
            Console.WriteLine(car.ToString());
        }
        static ICarFactory LoadFactory(ICarFactory facotry)
        {
                    return facotry as ICarFactory;
        }
    }
}
