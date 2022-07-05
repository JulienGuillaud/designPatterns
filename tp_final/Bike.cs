using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bike inherit Vehicle class (which have a simple print function)
public class Bike : Vehicle
{
    private string brand;
    public Bike(string modele, string immat)
    {
        this.brand = modele;
        this.immatPlate = immat;
    }
    public override void print()
    {
        Console.WriteLine("Bike : "+this.brand);
    }
}
