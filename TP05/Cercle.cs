using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    public class Cercle : Figure
    {
        double x, y, rayon, surface;
        public Cercle(double rayon, double x = 1, double y = 1) : base (x, y)
        {
            this.x = x;
            this.y = y;
            this.rayon = rayon;
        }

        public override double Surface()
        {
            this.surface = Math.PI * Math.Pow(this.rayon, 2);
            return this.surface;
        }
    }
}
