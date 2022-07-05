using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CarModel{
    private string modelName;

    public CarModel(string name){
        this.modelName = name;
    }

    public string getName()
    {
        return this.modelName;
    }
    public void setName(string name)
    {
        this.modelName = name;
    }
}