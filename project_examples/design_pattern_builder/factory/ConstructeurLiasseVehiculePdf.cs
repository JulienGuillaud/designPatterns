using design_pattern_builder.modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_builder.factory
{
    public class ConstructeurLiasseVehiculePdf :
 ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculePdf()
        {
            liasse = new LiassePdf();
        }

        public override void construitBonDeCommande(string
          nomClient)
        {
            string document;
            document = "<PDF> Bon de commande Client : " +
              nomClient + "</PDF>";
            liasse.ajouteDocument(document);
        }

        public override void construitDemandeImmatriculation
          (string nomDemandeur)
        {
            string document;
            document = "<PDF> Demande d'immatriculation Demandeur : " +
              nomDemandeur + "</PDF>";
            liasse.ajouteDocument(document);
        }
    }

}
