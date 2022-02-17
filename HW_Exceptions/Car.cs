using HW_Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions
{
    internal class Car
    {
        public string Brand;
        public bool TotalLost { get; set; }
        public bool NeedsRepair { get; set; }

        public Car(string brand, bool totalLost, bool needsRepair)
        {
            if (totalLost && needsRepair == false)
                throw new RepairMismatchException("The car details are incorrect");
            Brand = brand;
            TotalLost = totalLost;
            NeedsRepair = needsRepair;
        }
    }
}
