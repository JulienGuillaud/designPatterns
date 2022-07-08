using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Printer
{
    private static Printer _instance = null;
    public IList<Vehicle> printerWaitList { get; protected set; }

    private Printer()
    {
        printerWaitList = new List<Vehicle>();
    }

    public static Printer Instance()
    {
        if (_instance == null)
            _instance = new Printer();
        return _instance;
    }
    public void addCar(string littleLabel, string immat, CarBrand brand, CarModel model)
    {
        Car car = new Car(littleLabel, immat, brand, model);
        printerWaitList.Add(car);
    }
    public void addBike(string modele, string immat)
    {
        Bike bike = new Bike(modele, immat);
        printerWaitList.Add(bike);
    }

    public void resetPrinter()
    {
        printerWaitList = new List<Vehicle>();
    }


    public void printInvoice()
    {
        for (int i = 0; i < printerWaitList.Count; i++)
        {
            printerWaitList[i].print();
        }
    }

    public void printAllPlates()
    {
        for (int i = 0; i < printerWaitList.Count; i++)
        {
            printerWaitList[i].printImmatPlate();
        }
    }

}