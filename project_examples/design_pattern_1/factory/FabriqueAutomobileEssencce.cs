using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_1
{
    public class FabriqueAutomobileEssence : FabriqueVehicule
    {
        public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileEssence(modele, couleur, puissance, espace);
        }
    }
}
