using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    public class Figure
    {
        double x, y, surface;

        public Figure(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Surface()
        {
            return this.surface;
        }

        public string Informations()
        {
            return "Les coordonnées du centre de la figure sont : x = " + this.x + " et y = " + this.y;
        }
    }
}
