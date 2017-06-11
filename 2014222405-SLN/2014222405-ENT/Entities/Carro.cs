using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405_ENT
{
    public abstract class Carro
    {
        public int CarroId { get; set; }
        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }
		public TipoCarro TipoCarro { get; set; }

		public virtual Asiento Asiento { get; set; }
		public int AsientoId { get; set; }

		public virtual Propietario Propietario { get; set; }
		public int PropietarioId { get; set; }

		public virtual Parabrisas Parabrisas { get; set; }
        public int ParabrisasId { get; set; }
		        
        public virtual Ensambladora Ensambladora { get; set; }
		public int EnsambladoraId { get; set; }
				      
        public virtual Llanta Llanta { get; set; }
		public int LlantaId { get; set; }

		public virtual Volante Volante { get; set; }
		public int VolanteId { get; set; }


		public Carro()
        {
        }
    }       

}
