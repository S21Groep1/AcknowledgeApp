using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace AcknowledgeApp.Models
{
    public class Viewmodel
    {
        Actionpoint actiepunt = new Actionpoint();
        
        
        public List<string> Actionpoints
        {
            get
            {
                return actiepunt.Softskilllist(); ;
            }
        }


    }
}
