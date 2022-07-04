using design_pattern_builder.modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_builder.factory
{
    public class ConstructeurLiasseVehiculeHtml :
 ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeHtml()
        {
            liasse = new LiasseHtml();
        }

        public override void construitBonDeCommande(string
          nomClient)
        {
            string document;
            document = "<HTML>Bon de commande Client : " +
              nomClient + "</HTML>";
            liasse.ajouteDocument(document);
        }

        public override void construitDemandeImmatriculation
          (string nomDemandeur)
        {
            string document;
            document =
              "<HTML>Demande d'immatriculation Demandeur : " +
              nomDemandeur + "</HTML>";
            liasse.ajouteDocument(document);
        }
    }
}
