using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OisinLynch_S00189006
{
    public class Phone
    {
        //Properties
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        //Methods 
        public void IncreasePrice(decimal percentValue)
        {
            Price += percentValue / 100;
        }
    }
}
