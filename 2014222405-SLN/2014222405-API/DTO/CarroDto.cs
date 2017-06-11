using _2014222405_ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2014222405_API.DTO
{
    public class CarroDto
    {
        public int CarroId { get; set; }
        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }
		public TipoCarro TipoCarro { get; set; }
		public int AsientoId { get; set; }
		public int PropietarioId { get; set; }
        public int ParabrisasId { get; set; }
        public int LlantaId { get; set; }
		public int VolanteId { get; set; }
		public int EnsambladoraId { get; set; }
    }
}