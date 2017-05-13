using _2014222405.Entities.Entities;
using _2014222405.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Persistence.Repositories
{
    public class VolanteRepository : Repository<Volante>, IVolanteRepository
    {
        private readonly EnsambladoraDbContext _Context;

        private VolanteRepository()
            : base()
        {

        }

        public VolanteRepository(EnsambladoraDbContext context)
        {
            
            _Context = context;
        }




        void IRepository<Volante>.Add(Volante entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Volante>.AddRange(IEnumerable<Volante> entities)
        {
            throw new NotImplementedException();
        }

        Volante IRepository<Volante>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Volante> IRepository<Volante>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Volante> IRepository<Volante>.Find(System.Linq.Expressions.Expression<Func<Volante, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Volante>.Update(Volante entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Volante>.UpdateRange(IEnumerable<Volante> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Volante>.Delete(Volante entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Volante>.DeleteRange(IEnumerable<Volante> entities)
        {
            throw new NotImplementedException();
        }
    }
}
