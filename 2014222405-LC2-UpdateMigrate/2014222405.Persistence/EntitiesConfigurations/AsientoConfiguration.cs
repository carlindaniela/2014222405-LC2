using _2014222405.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Persistence.EntitiesConfigurations
{
    public class AsientoConfiguration : EntityTypeConfiguration<Asiento>
    {
        public AsientoConfiguration()
        {
            //Configuracion de la tabla
            ToTable("Asientos");
            HasKey(c => c.AsientoId);



            //Configuracion de las  relaciones
            HasRequired(c => c.Cinturon)
                .WithRequiredPrincipal(c => c.Asiento);

        }
    }
}
