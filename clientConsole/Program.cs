using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_pointCore;



namespace clientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CLpoint point1;
            CLpoint point2;
            CLvoyage voyage;
            List<CLpoint> etapes;

            point1 = new CLpoint(1, 1);
            point2 = new CLpoint(2, 2);
            etapes = new List<CLpoint>(2)
            {
                point1,
                point2
            };

            voyage = new CLvoyage(etapes);
            affichage(voyage);

            voyage.delPoint(point2);
            affichage(voyage);

            voyage.addPoint(new CLpoint());
            affichage(voyage);

            Console.WriteLine("Distance du voyage : {0}", voyage.distanceVoyage());
            // Console.Read();
        }
        static void affichage(CLvoyage voyage)
        {
            int i;
            for (i = 0; i < voyage.Points.Count(); i++)
            {
                Console.WriteLine("Point  : {0} - {1} - {2}", voyage.Points[i].ID, voyage.Points[i].X, voyage.Points[i].Y);
            }
            Console.WriteLine("-------------------");
        }
    }
}