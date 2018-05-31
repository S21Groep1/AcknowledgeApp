using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    interface IActionpointcontext
    {
        List<Actionpoint> GetActionpoints();

        void AddActionpoint(Actionpoint actionpoint);
    }
}
