using System;
using System.Collections.Generic;
using System.Text;

public class ScooterElectrique : Scooter
{
    public ScooterElectrique(string modele, string couleur, int puissance)
        : base(modele, couleur, puissance)
    {
    }

    public override void afficheCarac()
    {
        Console.WriteLine("Scooter électrique :");
        Console.WriteLine("Modele : " + modele);
        Console.WriteLine("Couleur : " + couleur);
        Console.WriteLine("Puissance : " + puissance);
    }
}
