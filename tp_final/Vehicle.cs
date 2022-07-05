using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Vehicle
{
    protected string immatPlate;

    public void printImmatPlate()
    {
        Console.WriteLine(immatPlate);
    }

    public abstract void print();
}