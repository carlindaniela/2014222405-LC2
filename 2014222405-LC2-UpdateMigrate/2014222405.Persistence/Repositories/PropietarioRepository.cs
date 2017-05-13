using _2014222405.Entities.Entities;
using _2014222405.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Persistence.Repositories
{
    public class PropietarioRepository : Repository<Propietario>, IPropietarioRepository
    {
        private readonly EnsambladoraDbContext _Context;

        private PropietarioRepository()
            : base()
        {

        }

        public PropietarioRepository(EnsambladoraDbContext context)
        {
            
            _Context = context;
        }



        void IRepository<Propietario>.Add(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.AddRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }

        Propietario IRepository<Propietario>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Propietario> IRepository<Propietario>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Propietario> IRepository<Propietario>.Find(System.Linq.Expressions.Expression<Func<Propietario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.Update(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.UpdateRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.Delete(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.DeleteRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }
    }
}
