﻿using _2014222405_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405_PER.EntitiesConfigurations
{
    public class LlantaConfiguration:EntityTypeConfiguration<Llanta>
    {
        public LlantaConfiguration()
        {
			//Configuracion de la tabla 
			ToTable("Llantas");
			HasKey(c => c.LlantaId);
			Property(c => c.LlantaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.NumSerie)
                .IsRequired();

        }
    }
}
