using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_1
{
    public class FabriqueAutomobileElectrique : FabriqueVehicule
    {
        public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileElectrique(modele, couleur, puissance, espace);
        }
    }
}
