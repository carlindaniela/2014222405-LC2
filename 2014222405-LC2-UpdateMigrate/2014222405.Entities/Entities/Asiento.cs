﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Entities.Entities
{
   public class Asiento
    {
    
        public int AsientoId { get; set; }
        public string NumSerie { get; set; }
        

        public Cinturon Cinturon { get; set; }
        public int CinturonId { get; set; }

       
        public Carro Carro { get; set; }
        public int CarroId { get; set; }

        public Asiento()
        {
            Cinturon = new Cinturon();
        }
    }
}
