using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_1
{
    // Catalogue class
    public abstract class Automobile
    {
        protected string modele;
        protected string couleur;
        protected int puissance;
        protected double espace;

        public Automobile(string modele, string couleur, int puissance, double espace)
        {
            this.modele = modele;
            this.couleur = couleur;
            this.puissance = puissance;
            this.espace = espace;
        }

        public abstract void afficheCarac();

    }
}
