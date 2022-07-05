using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CarBrand{
    private string brandName;

    public CarBrand(string name){
        this.brandName = name;
    }
    public string getName()
    {
        return this.brandName;
    }
    public void setName(string name)
    {
        this.brandName = name;
    }
}