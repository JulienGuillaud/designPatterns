using design_pattern_builder.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_builder.modeles
{
    public class Vendeur
    {
        protected ConstructeurLiasseVehicule constructeur;

        public Vendeur(ConstructeurLiasseVehicule constructeur)
        {
            this.constructeur = constructeur;
        }

        public Liasse construit(string nomClient)
        {
            constructeur.construitBonDeCommande(nomClient);
            constructeur.construitDemandeImmatriculation
              (nomClient);
            Liasse liasse = constructeur.resultat();
            return liasse;
        }
    }
}
