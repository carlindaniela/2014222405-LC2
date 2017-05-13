using _2014222405.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Persistence.EntitiesConfigurations
{
    public class LlantaConfiguration : EntityTypeConfiguration<Llanta>
    {
        public LlantaConfiguration()
        {
            //Configuracion de la tabla

            ToTable("Llantas");
            HasKey(c => c.LlantaId);
        }
    }
}
