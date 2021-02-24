using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public partial class Car
    {
        public void Reset()
        {
            brand = null;
            power = 0;
            color = null;
            price = 0;
            year = 0;
            count--;
        }


    }
}
