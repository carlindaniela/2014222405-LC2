using _2014222405.Entities.Entities;
using _2014222405.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Persistence.Repositories
{
    public class AutomovilRepository : Repository<Automovil>, IAutomovilRepository
    {
        private readonly EnsambladoraDbContext _Context;

        private AutomovilRepository()
            : base()
        {

        }

        public AutomovilRepository(EnsambladoraDbContext context)
        {
            
            _Context = context;
        }


        void IRepository<Automovil>.Add(Automovil entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Automovil>.AddRange(IEnumerable<Automovil> entities)
        {
            throw new NotImplementedException();
        }

        Automovil IRepository<Automovil>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Automovil> IRepository<Automovil>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Automovil> IRepository<Automovil>.Find(System.Linq.Expressions.Expression<Func<Automovil, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Automovil>.Update(Automovil entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Automovil>.UpdateRange(IEnumerable<Automovil> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Automovil>.Delete(Automovil entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Automovil>.DeleteRange(IEnumerable<Automovil> entities)
        {
            throw new NotImplementedException();
        }
    }
}
