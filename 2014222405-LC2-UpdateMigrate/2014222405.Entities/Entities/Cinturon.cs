﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Entities.Entities
{
   public class Cinturon
    {
        public int CinturonId { get; set; }
        public string NumSerie { get; set; }
        public int Metraje { get; set; }

   
        public Asiento Asiento { get; set; }
        public int AsientoId { get; set; }
    }
}
