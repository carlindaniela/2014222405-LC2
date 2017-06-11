using _2014222405_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405_PER.EntitiesConfigurations
{
    public class ParabrisasConfiguration:EntityTypeConfiguration<Parabrisas>
    {
        public ParabrisasConfiguration()
        {
			//Configuracion de la tabla 
			ToTable("Parabrisas");
			HasKey(c => c.ParabrisasId);
			Property(c => c.NumSerie)
                .IsRequired()
                .HasMaxLength(10);
            Property(c => c.ParabrisasId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
