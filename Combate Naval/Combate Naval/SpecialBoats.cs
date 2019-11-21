using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combate_Naval
{
    public class SpecialBoats : Boats
    {
        private string specialAbilittie;

        public SpecialBoats(string name, int lifePoints, string specialAbilittie)
        {
            this.specialAbilittie = specialAbilittie;
            Name = name;
            LifePoints = lifePoints;
        }
    }
}
