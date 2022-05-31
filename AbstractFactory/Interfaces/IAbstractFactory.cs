using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    internal interface IAbstractFactory
    {
        public void getWall() { }
        public void getDoor() { }
        public void getRoof() { }
    }
}
