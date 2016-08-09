using DesignPatternsLibrary.Cars.BMWs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary
{
    public class BMWFactory : ICarFactory
    {
        public IAuto CreateEconomyCar()
        {
            return new BMWEconomy();
        }

        public IAuto CreateLuxaryCar()
        {
            return new BMWLuxary();
        }

        public IAuto CreateSportsCar()
        {
            return new BMWSport();
        }
    }
}
