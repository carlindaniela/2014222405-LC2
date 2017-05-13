﻿using _2014222405.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Persistence.EntitiesConfigurations
{
    public class ParabrisaConfiguration : EntityTypeConfiguration<Parabrisa>
    {
        public ParabrisaConfiguration()
        {
            //Configuracion de la tabla

            ToTable("Parabrisas");
            HasKey(c => c.ParabrisasId);
        }
    }
}
