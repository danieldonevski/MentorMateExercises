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
            Person worker = new Worker(28, "Ivan");
            worker.GrowUp(2);
            worker.IntroduceYourself();

            Person student = new Student(18, "Ivan");
            student.IntroduceYourself();
        }
    }
}
