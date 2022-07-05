using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Printer : Invoice
{
    private static Printer _instance = null;
    
    private Printer()
    {
        transportList = new List<Vehicle>();
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
        transportList.Add(car);
    }
    public void addBike(string modele, string immat)
    {
        Bike bike = new Bike(modele, immat);
        transportList.Add(bike);
    }

    public void resetPrinter()
    {
        transportList = new List<Vehicle>();
    }


}