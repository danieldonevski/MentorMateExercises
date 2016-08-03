using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesAbstractionInterfaces
{
    class ExercisesAbstractionInterfacesProgram
    {
        static void Main(string[] args)
        {

            Vehicle car = new Car(1908, "Audi");
           
            Vehicle truck = new Truck(2008, "MAN");

            car.Start();
            car.Accelerate();

            truck.Start();
            truck.Accelerate();
            truck.Decelerate();
            truck.Stop();
            truck.Accelerate();
            car.Accelerate();

        }
    }
}
