using System;
using System.Collections.Generic;
using System.Text;

public interface FabriqueVehicule
{
    Automobile creerAutomobile(string modele, string couleur, int puissance, double espace);
    Scooter creerScooter(string modele, string couleur, int puissance);
}
