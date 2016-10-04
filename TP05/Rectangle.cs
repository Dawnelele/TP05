using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    class Rectangle : Figure
    {
        double x, y, longueur, largeur, surface;

        public Rectangle(double x, double y, double longueur, double largeur) : base(x, y)
        {
            this.x = x;
            this.y = y;
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public double Surface()
        {
            this.surface = this.longueur * this.largeur;
            return this.surface;
        }
    }
}
