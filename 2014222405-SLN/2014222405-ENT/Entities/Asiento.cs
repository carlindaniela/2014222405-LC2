﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405_ENT
{
    public class Asiento
    {


        public int AsientoId { get; set; }
        public string NumSerieAsiento { get; set; }
        public int CinturonId { get; set; }
        public virtual Cinturon Cinturon { get; set; }
        
        public Asiento()
        {
            
        }

    }
}
