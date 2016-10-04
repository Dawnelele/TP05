using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    class Cercle : Figure
    {
        double x, y, rayon, surface;
        public Cercle(double x, double y, double rayon) : base(x, y)
        {
            this.x = x;
            this.y = y;
            this.rayon = rayon;
        }

        public double Surface()
        {
            this.surface = Math.PI * Math.Pow(this.rayon, 2);
            return this.surface;
        }
    }
}
