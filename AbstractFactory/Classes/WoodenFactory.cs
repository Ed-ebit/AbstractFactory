using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
namespace AbstractFactory.Classes
{
    internal class WoodenFactory
    {
        public IWall getWall() {
            return new WoodenWall();
        }
    }
}
