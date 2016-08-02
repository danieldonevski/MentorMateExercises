using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesAbstractionInterfaces
{
    abstract class Person : IPerson
    {

        private int age;
        private string name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        public int Age { get; set; }

        public string Name { get; set; }

        public void GrowUp(int years)
        {
            Age += years;
        }

        public abstract void IntroduceYourself();
    }
}
