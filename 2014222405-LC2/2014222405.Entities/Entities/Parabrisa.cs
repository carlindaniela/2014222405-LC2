using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Entities.Entities
{
   public class Parabrisa
    {
        public int ParabrisasId { get; set; }
        public string NumSerie { get; set; }

      
        public Carro Carro { get; set; }
        public int CarroId { get; set; }
    }
}
