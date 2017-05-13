using _2014222405.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Persistence.EntitiesConfigurations
{
    public class EnsambladoraConfiguration : EntityTypeConfiguration<Ensambladora>
    {
        public EnsambladoraConfiguration()
        {
            //Configuracion de la tabla

            ToTable("Ensambladoras");
            HasKey(c => c.EnsambladoraId);
        }
    }
}
