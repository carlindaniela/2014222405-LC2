using _2014222405.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014222405.Persistence.Repositories
{
   public class UnityOfWork: IUnityOfWork
    {
        public IAsientoRepository Asientos { get; private set; }
        public IAutomovilRepository Automoviles { get; private set; }
        public IBusRepository Buses { get; private set; }
        public ICinturonRepository Cinturones { get; private set; }
        public IEnsambladoraRepository Ensambladoras { get; private set; }
        public ILlantaRepository Llantas { get; private set; }
        public IPropietarioRepository Propietarios { get; private set; }
        public IParabrisaRepository Parabrisas { get; private set; }
        public IVolanteRepository Volantes { get; private set;}

        
        private readonly EnsambladoraDbContext _Context;
        private UnityOfWork()
        {
           
            _Context = new EnsambladoraDbContext();

            Asientos = new AsientoRepository(_Context);
            Automoviles = new AutomovilRepository(_Context);
            Buses = new BusRepository(_Context);
            Cinturones = new CinturonRepository(_Context);
            Ensambladoras = new EnsambladoraRepository(_Context);
            Llantas = new LlantaRepository(_Context);
            Parabrisas = new ParabrisaRepository(_Context);
            Propietarios = new PropietarioRepository(_Context);
            Volantes = new VolanteRepository(_Context);
        }

        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();
        public static UnityOfWork Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                    {
                        _Instance = new UnityOfWork();
                    }
                }

                return _Instance;
            }
        }

       public  int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
