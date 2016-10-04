using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    public class Rectangle : Figure
    {
        double x, y, longueur, largeur, surface;

        public Rectangle(double longueur, double largeur, double x = 1, double y = 1) : base(x, y)
        {
            this.x = x;
            this.y = y;
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public override double Surface()
        {
            this.surface = this.longueur * this.largeur;
            return this.surface;
        }
    }
}
