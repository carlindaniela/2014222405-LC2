﻿using _2014222405_ENT;
using _2014222405_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _2014222405_PER.Repositories
{
    public class VolanteRepository : Repository<Volante>, IVolanteRepository
    {
        public VolanteRepository(EnsambladoraDbContext context) : base(context)
        {
        }
    }
}
