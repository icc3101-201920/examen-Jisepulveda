using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combate_Naval
{
    public class NormalBoats : Boats
    {
        public NormalBoats(string name, int lifepoints)
        {
            this.Name = name;
            this.LifePoints = lifepoints;
        }

        public void attack(Board board)
        {

        }

    }
}
