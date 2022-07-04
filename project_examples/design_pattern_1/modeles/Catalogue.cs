using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_1.modeles
{
    public class Catalogue
    {
        int nbAutos = 3;
        int nbAutos = 3;

        public Catalogue()
        {
            FabriqueVehicule fabrique;
            Automobile[] autos = new Automobile[nbAutos];
            Scooter[] scooters = new Scooter[nbScooters];
            Console.WriteLine("Voulez-vous utiliser " +
                "des vehicules électriques (1) ou à essence (2) :?");
            string choix = Console.ReadLine();
            if(choix == "1"){
                fabrique = new FabriqueVehiculeElectricite();
            }else{
                fabrique = new FabriqueVehiculeEssence();
            }
            for(int index = 0; index < nbAutos ; index++){
                autos[index] = fabrique.creerAutomobile("standard", "jaune", 6+index, 3.2);
            }
            for(int index = 0; index < nbScooter ; index++){
                scooters[index] = fabrique.creerScooter("classic", "rouge", 2+index);
            }
            foreach (Automobile auto in autos)
            {
                auto.afficheCarac();
            }
            foreach (Scooter scooter in scooters)
            {
                scooter.afficheCarac();
            }
        }

    }
}
