using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Caster
    {
        public Spell SpellType { get; set; }
        public void SetSpell(Spell spellType)
        {
            this.SpellType = spellType;
        }
        public void Cast()
        {
            SpellType.Cast();
        }
    }
}
