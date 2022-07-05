using System;

public class InfosVendeur : Document
{
    public override void affiche()
    {
        Console.WriteLine("Affiche les informations vendeur : " +
          contenu);
    }

    public override void imprime()
    {
        Console.WriteLine("Imprime les informations vendeur : " +
          contenu);
    }
}
