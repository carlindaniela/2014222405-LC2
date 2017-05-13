using _2014222405.Entities.Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Entities.Entities
{
   public class Ensambladora
    {
        public int EnsambladoraId { get; set; }
        public List<Carro> Carros { get; set; }



        public Ensambladora()
        {
            Carros = new List<Carro>();
        }

     
    }
}
