using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    internal class WoodenRoof: IRoof
    {
        public string Description()
        {
            return "Ich bin ein Holzdach!";
        }
    }
}
