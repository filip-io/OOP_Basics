using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    class Circle
    {
        private double _radius { get; set; }


        public Circle(double radius)
        {
            _radius = radius;
        }


        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }                    
    }
}
