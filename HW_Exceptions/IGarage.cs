using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions
{
    internal interface IGarage
    {
        public void AddCar(Car car);
        public void TakeOutCar(Car car);
        public void FixCar(Car car);


    }
}
