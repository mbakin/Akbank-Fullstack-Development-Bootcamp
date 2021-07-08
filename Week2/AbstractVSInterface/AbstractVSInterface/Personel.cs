using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractVSInterface
{
    class Personel
    {
        public string Name { get; set; }
        public string LastName{ get; set; }
        public  IAddress Address { get; set; }
    }

    public interface IAddress
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
    }

    public class HomeAddress : IAddress
    {
        public string City { get ; set; }
        public string Country { get; set; }
        public string Street { get; set ; }
        public string State { get ; set ; }

        

    }

    public class BussinessAddress : IAddress
    {
        public string City { get  ; set  ; }
        public string Country { get  ; set  ; }
        public string Street { get  ; set  ; }
        public string State { get  ; set  ; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
