using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class HealSpell : Spell
    {
        public void Cast()
        {
            Console.WriteLine("Shut up and let me save your life!");
        }
    }
}
