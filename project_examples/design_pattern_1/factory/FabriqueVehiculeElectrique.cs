using System;
using System.Collections.Generic;
using System.Text;

public class FabriqueVehiculeElectrique : FabriqueVehicule
{
    public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace)
    {
        return new AutomobileElectrique(modele, couleur, puissance, espace);
    }
    public Scooter creerScooter(string modele, string couleur, int puissance)
    {
        return new ScooterElectrique(modele, couleur, puissance);
    }
}
