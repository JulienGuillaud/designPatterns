// See https://aka.ms/new-console-template for more information

using design_pattern_builder.factory;

namespace design_pattern_builder.modeles
{
    public class ClientVehicule
{
    static void Main(string[] args)
    {
        ConstructeurLiasseVehicule constructeur;
        Console.WriteLine("Voulez-vous construire " +
          "des liasses HTML (1) ou PDF (2) :");
        string choix = Console.ReadLine();
        if (choix == "1")
        {
            constructeur = new ConstructeurLiasseVehiculeHtml();
        }
        else
        {
            constructeur = new ConstructeurLiasseVehiculePdf();
        }
        Vendeur vendeur = new Vendeur(constructeur);
        Liasse liasse = vendeur.construit("Martin");
        liasse.imprime();
    }
}

}