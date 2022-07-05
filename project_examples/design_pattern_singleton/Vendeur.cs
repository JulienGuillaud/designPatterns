using System.Collections.Generic;

public class Vendeur
{
    private static Vendeur _instance = null;
    private List<Document> documents;

    private Vendeur()
    {
        documents = new List<Document>();
    }
     
    public static Vendeur Instance()
    {
        if (_instance == null)
            _instance = new Vendeur();
        return _instance;
    }

    public void ajoute(Document doc)
    {
        documents.Add(doc);
    }
    
    public void imprimeAll()
    {
        foreach (Document doc in documents)
        {
            doc.imprime();
        }
    }

    public void retire(Document doc)
    {
        documents.Remove(doc);
    }
}
