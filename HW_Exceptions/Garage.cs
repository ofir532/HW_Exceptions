using HW_Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions
{
    internal class Garage : IGarage
    {
        private Car[] cars;
        private string[] carTypes;

        public Garage(string[] carTypes)
        {
            this.carTypes = carTypes;
            this.cars = new Car[5];
        }

        public void AddCar(Car car)
        {
            if (car == null || car.Brand == null)
                throw new CarNullException("Missing car details.");
            if (cars.Length == cars.Count(x => x != null))
                throw new TheGarageIsFull("The garage is full.");
            if (Array.Exists(cars, x => x == car) == true)
                throw new CarAlreadyHereException("Car already here.");
            if (car.TotalLost)
                throw new WeDoNotFixTotalLostException("We don't repair total lost car.");
            if (Array.Exists(carTypes, x => x == car.Brand) == false)
                throw new WrongGarageException("We don't repair this type of car.");
            if (car.NeedsRepair == false)
                throw new RepairMismatchException("The car doesn't need to repair.");
            cars[Array.FindIndex(cars, x => x == null)] = car;
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    if (cars[i] == null)
            //    {
            //        cars[i] = car;
            //        break;
            //    }
            //}
        }

        public void FixCar(Car car)
        {
            if (car == null)
                throw new CarNullException("Missing car details.");
            if (Array.Exists(cars, x => x == car) == false)
                throw new CarNotInGarageException("Car not in garage");
            if (car.NeedsRepair == false)
                throw new RepairMismatchException("The car doesn't need to repair.");
            car.NeedsRepair = false;
        }

        public void TakeOutCar(Car car)
        {
            if (car == null)
                throw new CarNullException("Missing car details.");
            if (Array.Exists(cars, x => x == car) == false)
                throw new CarNotInGarageException("Car not in garage");
            if (car.NeedsRepair)
                throw new CarNotReadyException("Car not ready");

            cars[Array.FindIndex(cars, x => x == car)] = null;
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    if (cars[i] == car)
            //    {
            //        cars[i] = null;
            //        break;
            //    }
            //}
        }
    }
}
