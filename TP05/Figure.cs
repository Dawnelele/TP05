using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    abstract public class Figure
    {
        double x, y, surface;

        public Figure(double x = 1, double y = 1)
        {
            this.x = x;
            this.y = y;
        }

        abstract public double Surface();

        public string Informations()
        {
            return this.x + " " + this.y;
        }
    }
}
