using _2014222405.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Persistence.EntitiesConfigurations
{
    public class CarroConfiguration : EntityTypeConfiguration<Carro>
    {
        public CarroConfiguration()
        {
            //Configuracion de la tabla

            ToTable("Carros");
            HasKey(c => c.CarroId);
            Property(c => c.NumSerieChasis).IsRequired();

            Map<Bus>(c => c.Requires("Discriminator").HasValue("Bus"));
            Map<Automovil>(c => c.Requires("Discriminator").HasValue("Automovil"));




            //Configuracion de las relaciones

            HasMany(c => c.Llantas)
                .WithRequired(c => c.Carro);


            HasMany(c => c.Asientos)
                .WithRequired(c => c.Carro);


            HasRequired(c => c.Propietario)
                .WithMany(c => c.Carros);


            HasRequired(c => c.Volante)
                .WithRequiredPrincipal(c => c.Carro);


            HasMany(c => c.Parabrisas)
                .WithRequired(c => c.Carro);


            HasRequired(c => c.Ensambladora)
                .WithMany(c => c.Carros);
        }
    }
}
