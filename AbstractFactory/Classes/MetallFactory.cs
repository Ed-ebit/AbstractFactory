using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory.Classes
{
    internal class MetallFactory
    {
        public IWall getWall()
        {
            return new MetallWall();
        }
        public IDoor getDoor()
        {
            return new MetallDoor();
        }
        public IRoof getRoof()
        {
            return new MetallRoof();
        }
    }
}
