using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class EmissoraRepository : IEmissoraRepository
    {
        private readonly ContextApp _contexto;

        public EmissoraRepository(ContextApp contexto)
        {
            _contexto = contexto;
        }

        public void Add(Emissora emissora)
        {
            Emissora newEmissora = new Emissora() { Nome = emissora.Nome };

            _contexto.Emissoras.Add(newEmissora);
            _contexto.SaveChanges();
        }

        public bool Exists(Emissora emissora)
        {
            var result = _contexto.Emissoras.Where(x => x.Nome.ToLower().Equals(emissora.Nome.ToLower())).FirstOrDefault();

            return result != null;
        }

        public List<Emissora> Get()
        {
            return _contexto.Emissoras.ToList();
        }

        public Emissora Get(int id)
        {
            return _contexto.Emissoras.Find(id);
        }

        public void Remove(Emissora emissora)
        {
            _contexto.Emissoras.Remove(emissora);
            _contexto.SaveChanges();            
        }

        public void Update(Emissora emissora)
        {
            _contexto.Entry(emissora).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _contexto.SaveChanges();
        }
    }
}
