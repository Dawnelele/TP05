using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP05;


namespace TP05_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double surfaceTotale;
            Figure[] tableau = new Figure[2];
            tableau[0] = new Cercle(10);
            tableau[1] = new Rectangle(15, 10, 3, 4);

            Console.WriteLine("Avec un tableau \n");

            Console.WriteLine("Rectangle centré au point de coordonnées " + tableau[1].Informations());
            Console.WriteLine("Cercle centré au point de coordonnées " + tableau[0].Informations());

            surfaceTotale = Math.Round(tableau[0].Surface() + tableau[1].Surface(), 2);

            Console.WriteLine("Surface totale : " + surfaceTotale + "\n");

            surfaceTotale = 0;

            List<Figure> listFigures = new List<Figure>();
            listFigures.Add(new Cercle(10));
            listFigures.Add(new Rectangle(15, 10, 3, 4));

            Console.WriteLine("Avec une collection \n");

            Console.WriteLine("Rectangle centré au point de coordonnées " + listFigures.First().Informations());
            Console.WriteLine("Cercle centré au point de coordonnées " + listFigures.Last().Informations());

            surfaceTotale = Math.Round(listFigures.First().Surface() + listFigures.Last().Surface(), 2);

            Console.WriteLine("Surface totale : " + surfaceTotale);

            Console.ReadLine();
        }
    }
}
