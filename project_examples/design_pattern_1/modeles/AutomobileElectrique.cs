using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_1
{
    public class AutomobileElectrique : Automobile
    {
        public AutomobileElectrique(string modele, string couleur, int puissance, double espace)
           : base(modele, couleur, puissance, espace)
        {
        }

        public override void afficheCarac()
        {
            Console.WriteLine("Automobile électrique :");
            Console.WriteLine("Modele : " + modele);
            Console.WriteLine("Couleur : " + couleur);
            Console.WriteLine("Puissance : " + puissance);
            Console.WriteLine("Espace : " + espace);
        }
    }
}
