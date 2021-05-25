using Domain.CustomResponse;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class AudienciaRepository : IAudienciaRepository
    {
        private readonly ContextApp _contexto;

        public AudienciaRepository(ContextApp contexto)
        {
            _contexto = contexto;            
        }

        public void Add(Audiencia audiencia)
        {
            var newAudiencia = new Audiencia()
            {
                Data_hora_audiencia = audiencia.Data_hora_audiencia,
                Emissora_audienciaId = audiencia.Emissora_audienciaId,
                Pontos_audiencia = audiencia.Pontos_audiencia
            };
            
            _contexto.Audiencias.Add(newAudiencia);
            _contexto.SaveChanges();
        }

        public bool Exists(Audiencia audiencia)
        {
            var result = _contexto.Audiencias.Where(x => x.Data_hora_audiencia == audiencia.Data_hora_audiencia 
                                                        && x.Emissora_audienciaId == audiencia.Emissora_audienciaId).FirstOrDefault();
            return result != null;
        }

        public List<Audiencia> Get()
        {
            return _contexto.Audiencias.Include(x => x.Emissora_audiencia).ToList();
        }

        public Audiencia Get(int id)
        {
            return _contexto.Audiencias.Find(id);
        }

        public List<GroupAudiencia> GetAverage(DateTime dtAudiencia)
        {
            var avgAudiencia = _contexto.Audiencias
                  .GroupBy(p => p.Emissora_audiencia.Nome)
                  .Select(g => new GroupAudiencia
                  {
                      Emissora_Nome = g.Key,
                      Data = dtAudiencia,
                      Valor = g.Average(x => x.Pontos_audiencia)
                  })
                  .ToList();

            return avgAudiencia;
        }

        public List<GroupAudiencia> GetSummary(DateTime dtAudiencia)
        {
            var avgAudiencia = _contexto.Audiencias
                  .GroupBy(p => p.Emissora_audiencia.Nome)
                  .Select(g => new GroupAudiencia
                  {
                      Emissora_Nome = g.Key,
                      Data = dtAudiencia,
                      Valor = g.Sum(x => x.Pontos_audiencia)
                  })
                  .ToList();

            return avgAudiencia;
        }

        public void Remove(Audiencia audiencia)
        {
            _contexto.Audiencias.Remove(audiencia);
            _contexto.SaveChanges();            
        }

        public void Update(Audiencia audiencia)
        {
            _contexto.Entry(audiencia).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _contexto.SaveChanges();
        }
    }
}
