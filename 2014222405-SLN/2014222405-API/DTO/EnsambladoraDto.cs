﻿using _2014222405_ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2014222405_API.DTO
{
    public class EnsambladoraDto
    {
        public int EnsambladoraId { get; set; }
        public string _Ensambladora { get; set; }
        public TipoCarro TipoCarro { get; set; }
    }
}