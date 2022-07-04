using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_1
{
    public class FabriqueScooterEssence : FabriqueVehicule
    {
        public Scooter creerScooter(string modele, string couleur, int puissance)
        {
            return new ScooterEssence(modele, couleur, puissance);
        }
    }
}
