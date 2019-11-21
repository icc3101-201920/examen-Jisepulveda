using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combate_Naval
{
    public abstract class Boats
    {
        private string name;
        private int lifePoints;

        public Boats(string name, int lifePoints)
        {
            this.name = name;
            this.lifePoints = lifePoints;
        }

        public int LifePoints
        {
            get
            {
                return this.lifePoints;
            }
            set
            {
                this.lifePoints = LifePoints;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = Name;
            }
        }

        public void move(Board board, int direction)
        {
            
        }

        

    }
}
