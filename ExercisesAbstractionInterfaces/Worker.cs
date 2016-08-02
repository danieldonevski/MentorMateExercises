using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesAbstractionInterfaces
{
    class Worker : Person
    {
        public Worker(int age,string name) 
            :base(age,name)
        {

        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Hello i'm a Worker i'm {0} years old and my Name is {1}!", Age,Name);
        }
    }
}
