using _2014222405.Entities.Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Entities.Entities
{
   public class Bus: Carro
    {
        
        public TipoBus TipoBus { get; set; }

        
        public Bus( TipoBus tipoBus)
            
        {
            
            TipoBus = tipoBus;
        }

        public Bus()
        {

        }
    }
}
