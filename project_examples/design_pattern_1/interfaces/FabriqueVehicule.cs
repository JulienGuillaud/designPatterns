using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_1
{
    public interface FabriqueVehicule
    {
        Automobile creerAutomobile(string modele, string couleur, int puissance, double espace);
    }
}
