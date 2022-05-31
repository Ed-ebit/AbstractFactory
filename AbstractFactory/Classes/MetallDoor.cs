using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    public class MetallDoor:IDoor
    {
        public Boolean IsOpen() {
            return false;
        }

        public string Description()
        {
            return "Ich bin eine Metalltür!";
        }
    }
}
