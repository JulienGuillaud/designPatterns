using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Invoice
{
    public IList<Vehicle> transportList { get; protected set; }
    
    public void printInvoice()
    {
        for (int i = 0; i < transportList.Count; i++)
        {
            transportList[i].print();
        }
    }
    
    public void printAllPlates()
    {
        for (int i = 0; i < transportList.Count; i++)
        {
            transportList[i].printImmatPlate();
        }
    }
}
