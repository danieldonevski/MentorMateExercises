using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesAbstractionInterfaces
{
    class Student : Person
    {
        public Student(int age, string name) 
            : base(age, name)
        {
            
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Hello i'm a Student i'm {0} years old and my Name is {1}!", Age, Name);
        }
    }
}
