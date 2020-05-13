using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OisinLynch_S00189006
{
    public class Phone
    {
        //Properties
        [Key]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        //Cpntructors
        public Phone(string name, decimal price, string operatingSystem, string os_Image, string phone_Image)
        {
            Name = name;
            Price = price;
            OperatingSystem = operatingSystem;
            OS_Image = os_Image;
            Phone_Image = phone_Image;
        }

        public Phone()
        {

        }

        //Methods 
        public void IncreasePrice(decimal percentValue)
        {
            decimal value = Price * percentValue;
            Price += value;
        }
    }

    public class PhoneData : DbContext
    {
        public PhoneData():base("MyPhoneData") { }

        public DbSet<Phone> Phones { get; set; }
    }

}
