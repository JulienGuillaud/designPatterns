using System;

public class Seller
{
    static void Main(string[] args)
    {
        // I create some car brands and model
        CarBrand renault = new CarBrand("Renault");
        CarBrand peugeot = new CarBrand("Peugeot");

        CarModel megane = new CarModel("Megane");
        CarModel p308 = new CarModel("308");

        // Singleton, because we only have 1 printer which can be used from everywhere
        Printer printer = Printer.Instance();

        // I add a invoice in my printer wait list for a car (which have is a vehicle with brand and model
        printer.addCar("ma 1ere Voiture", "AA-123-BB", renault, megane);
        printer.addCar("ma 2eme Voiture", "AA-123-BB", peugeot, p308);

        // I add a bike which don't have brand or model (both bike and car ar vehicle. Bike don't have brand or model just to show compoition and heritage)
        printer.addBike("BMW", "BB-345-CC");
        
        // I can print all the plates (from the Vehicle parent class)
        printer.printAllPlates();
        // I can print the invoice (list of vehicle added to the printer)
        printer.printInvoice();

        // Reset printer
        printer.resetPrinter();
        // Check if empty
        printer.printInvoice();

    }

}