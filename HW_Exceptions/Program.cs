using HW_Exceptions.Exceptions;
using System;

namespace HW_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car(brand: "Mazda", totalLost: false, needsRepair: true);
            try { Car c2 = new Car(brand: "Toyota", totalLost: true, needsRepair: false); }
            catch (RepairMismatchException) { Car cc2 = new Car(brand: "Toyota", totalLost: true, needsRepair: true); }
            Car c2_1 = new Car(brand: "Toyota", totalLost: false, needsRepair: true);
            Car c2_2 = new Car(brand: "Toyota", totalLost: true, needsRepair: true);
            Car c3 = new Car(brand: "Lexus", totalLost: false, needsRepair: false);
            Car c4 = new Car(brand: "Suzuki", totalLost: false, needsRepair: true);
            Car c5 = new Car(brand: "Honda", totalLost: false, needsRepair: true);
            Car c6 = new Car(brand: "Mitsubishi", totalLost: false, needsRepair: true);
            Car c6_1 = new Car(brand: "Mitsubishi", totalLost: false, needsRepair: true);
            Car c6_2 = new Car(brand: "Mitsubishi", totalLost: false, needsRepair: true);
            Car c7 = new Car(brand: "Porsche", totalLost: false, needsRepair: false);
            Car c8 = new Car(brand: "Jaguar", totalLost: false, needsRepair: false);
            Car c9 = new Car(brand: "Volvo", totalLost: false, needsRepair: true);
            Car c10 = new Car(brand: "Tesla", totalLost: false, needsRepair: false);
            Car c11 = new Car(brand: "Renault", totalLost: false, needsRepair: true);
            Car c12 = new Car(brand: "Renault", totalLost: false, needsRepair: true);
            string[] japBrands = { "Mazda", "Toyota", "Lexus", "Suzuki", "Honda", "Mitsubishi" };
            string[] allCarBrands = { "Mazda", "Toyota", "Lexus", "Suzuki", "Honda", "Mitsubishi", "Porsche", "Jaguar", "Volvo", "Tesla", "Renault" };
            Garage japGarage = new Garage(japBrands);
            Garage garage = new Garage(allCarBrands);
            japGarage.AddCar(c1);
            try
            {
                japGarage.AddCar(c1);
            }
            catch (CarAlreadyHereException ex)
            {
                Console.WriteLine(ex.Message);
            }
            japGarage.AddCar(c2_1);
            try
            {
                japGarage.AddCar(c2_2);
            }
            catch(WeDoNotFixTotalLostException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                japGarage.AddCar(c3);
            }
            catch (RepairMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
            japGarage.AddCar(c4);
            try
            {
                japGarage.AddCar(c7);
            }
            catch(WrongGarageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            japGarage.AddCar(c5);
            japGarage.AddCar(c6);
            try
            {
                japGarage.AddCar(c6_1);
            }
            catch(TheGarageIsFull ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                japGarage.TakeOutCar(c1);
            }
            catch(CarNotReadyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                japGarage.TakeOutCar(c12);
            }
            catch (CarNotInGarageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                japGarage.FixCar(c12);
            }
            catch (CarNotInGarageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            japGarage.FixCar(c1);
            try
            {
                japGarage.FixCar(c1);
            }
            catch (RepairMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
            japGarage.TakeOutCar(c1);
            japGarage.AddCar(c6_2);
        }
    }
}
