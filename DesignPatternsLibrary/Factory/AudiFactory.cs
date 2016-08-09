using DesignPatternsLibrary.Cars.Audis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary
{
    public class AudiFactory : ICarFactory
    {
        public IAuto CreateEconomyCar()
        {
            return new AudiEconomy();
        }

        public IAuto CreateLuxaryCar()
        {
            return new AudiLuxary();
        }

        public IAuto CreateSportsCar()
        {
            return new AudiSport();
        }

    }
}
