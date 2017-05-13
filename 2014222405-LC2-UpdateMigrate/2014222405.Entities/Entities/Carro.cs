using _2014222405.Entities.Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Entities.Entities
{
    public abstract class  Carro
    {
        public int CarroId { get; set; }
        public TipoCarro TipoCarro { get; set; }
        public string NumSerieChasis { get; set; }

        
        public List<Llanta> Llantas { get; set; }

        public List<Asiento> Asientos { get; set; }

        public List<Parabrisa> Parabrisas { get; set; }

        public Volante Volante { get; set; }
        public int VolanteId { get; set; }
            
        public Propietario Propietario { get; set; }
        public int PropietarioId { get; set; }

        public Ensambladora Ensambladora { get; set; }
        public int EnsambladoraId { get; set; }
       

            

        public Carro()
        {
            
            Llantas = new List<Llanta>();
            Asientos = new List<Asiento>();
            Parabrisas = new List<Parabrisa>();
        }

        public Carro(Volante volante, List<Parabrisa> parabrisas, 
             Propietario propietario, TipoCarro tipoCarro)
        {
         

            Volante = volante;
            Parabrisas = parabrisas;
            Propietario = propietario;
            TipoCarro = tipoCarro;
          
           
        }

       
    }
    
}
