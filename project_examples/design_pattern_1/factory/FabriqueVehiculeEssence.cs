using System;
using System.Collections.Generic;
using System.Text;

public class FabriqueVehiculeEssence : FabriqueVehicule
{
    public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace)
    {
        return new AutomobileEssence(modele, couleur, puissance, espace);
    }
    public Scooter creerScooter(string modele, string couleur, int puissance)
    {
        return new ScooterEssence(modele, couleur, puissance);
    }
}
