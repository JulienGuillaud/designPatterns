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

        // Singleton, because we need only 1 printer to print invoices
        Printer printer = Printer.Instance();

        // I add a car to the invoice in my printer (add the vehicle in the vehicleList)
        printer.addCar("ma 1ere Voiture", "AA-123-BB", renault, megane);
        printer.addCar("ma 2eme Voiture", "AA-123-BB", peugeot, p308);
        // I add a bike
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