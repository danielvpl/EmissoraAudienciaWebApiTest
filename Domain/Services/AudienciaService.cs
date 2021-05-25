using Domain.CustomResponse;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain.Services
{
    public class AudienciaService : IAudienciaService
    {
        private readonly IAudienciaRepository _repository;
        public AudienciaService(IAudienciaRepository repository)
        {
            _repository = repository;
        }

        public void Add(Audiencia audiencia)
        {
            if (Exists(audiencia))
                throw new Exception("Este registro de audiência já foi cadastrado.");

            _repository.Add(audiencia);
        }

        public bool Exists(Audiencia audiencia)
        {
            return _repository.Exists(audiencia);
        }

        public List<Audiencia> Get()
        {
            return _repository.Get();
        }

        public List<GroupAudiencia> GetAverage(DateTime dtAudiencia)
        {
            return _repository.GetAverage(dtAudiencia);
        }

        public List<GroupAudiencia> GetSummary(DateTime dtAudiencia)
        {
            return _repository.GetSummary(dtAudiencia);
        }

        public void Remove(int id)
        {
            Audiencia deleteAudiencia = _repository.Get(id);
            
            if (deleteAudiencia == null)
                throw new Exception("Registro não encontrado.");
            
            _repository.Remove(deleteAudiencia);
        }

        public void Update(Audiencia audiencia)
        {
            _repository.Update(audiencia);
        }
    }
}
