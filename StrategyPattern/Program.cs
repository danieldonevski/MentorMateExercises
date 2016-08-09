using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var caster = new Caster();
            caster.SetSpell(new HealSpell());
            caster.Cast();
            caster.SetSpell(new DamagingSpell());
            caster.Cast();
      
        }
    }
}
