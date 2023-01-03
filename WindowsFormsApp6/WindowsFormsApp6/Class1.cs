using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Human : IHuman
    {
        public string dance(string file_location)
        {
            return file_location;
        }

        public string speak(string file_location)
        {
            return file_location;
        }
    }
    public class Omnic : IOmnic, IHuman
    {
        public string dance(string file_location)
        {
            return file_location;
        }

        public string meditate(string file_location)
        {
            return file_location;
        }

        public string speak(string file_location)
        {
            return file_location;
        }
    }


    public class Ravager : IHuman, IRavager, IOmnic
    {
        public string dance(string file_location)
        {
            return file_location;
        }

        public string meditate(string file_location)
        {
            return file_location;
        }

        public string speak(string file_location)
        {
            return file_location;
        }
    }
}

