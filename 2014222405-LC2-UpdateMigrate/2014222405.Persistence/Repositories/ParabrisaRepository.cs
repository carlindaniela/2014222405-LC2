using _2014222405.Entities.Entities;
using _2014222405.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Persistence.Repositories
{
    public class ParabrisaRepository : Repository<Parabrisa>, IParabrisaRepository
    {
         private readonly EnsambladoraDbContext _Context;

         private ParabrisaRepository()
             : base()
         {

         }

        public ParabrisaRepository(EnsambladoraDbContext context)
        {
           
            _Context = context;
        }



        void IRepository<Parabrisa>.Add(Parabrisa entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisa>.AddRange(IEnumerable<Parabrisa> entities)
        {
            throw new NotImplementedException();
        }

        Parabrisa IRepository<Parabrisa>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Parabrisa> IRepository<Parabrisa>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Parabrisa> IRepository<Parabrisa>.Find(System.Linq.Expressions.Expression<Func<Parabrisa, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisa>.Update(Parabrisa entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisa>.UpdateRange(IEnumerable<Parabrisa> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisa>.Delete(Parabrisa entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisa>.DeleteRange(IEnumerable<Parabrisa> entities)
        {
            throw new NotImplementedException();
        }
    }
}
