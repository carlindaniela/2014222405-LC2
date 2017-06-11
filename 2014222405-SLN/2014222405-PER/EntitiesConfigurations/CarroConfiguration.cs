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
    public class CarroConfiguration:EntityTypeConfiguration<Carro>
    {
        public CarroConfiguration()
        {
			//Configuracion de la tabla 
			ToTable("Carros");
			HasKey(c => c.CarroId);
			Property(c => c.NumSerieChasis)
                .IsRequired()
                .IsMaxLength();
            Property(c => c.NumSerieMotor)
               .IsRequired()
               .HasMaxLength(10)
               .IsMaxLength();
			Property(c => c.CarroId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


			Map<Bus>(m => m.Requires("Discriminator").HasValue("Bus"));
            Map<Automovil>(m => m.Requires("Discriminator").HasValue("Automovil"));

            
            
        }
    }
}
