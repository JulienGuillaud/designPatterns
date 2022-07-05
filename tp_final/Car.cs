using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Car : Vehicle
{
    private string littleLabel;
    private CarBrand brand;
    private CarModel model;
    public Car(string littleLabel, string immat, CarBrand brand, CarModel model)
    {
        this.littleLabel = littleLabel;
        this.immatPlate = immat;
        this.brand = brand;
        this.model = model;
    }
    
    public override void print()
    {
        Console.WriteLine("Car : "+this.littleLabel + " marque : "+brand.getName()+" "+model.getName());
    }
}
