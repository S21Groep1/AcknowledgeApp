using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Actionpoint
    {
        List<string> softskills = new List<string>();
        private string actionpointname;

        public string Actionpointname { get => actionpointname; set => actionpointname = value; }



        public override string ToString()
        {
            return Actionpointname;
        }

    }
}
