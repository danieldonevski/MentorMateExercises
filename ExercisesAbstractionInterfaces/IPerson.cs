using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesAbstractionInterfaces
{
    interface IPerson
    {
        int Age { get; set; }
        string Name { get; set; }
        void GrowUp(int years);
        void IntroduceYourself();
    }
}
