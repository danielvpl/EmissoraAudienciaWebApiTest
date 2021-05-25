using Domain.CustomResponse;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Validators;
using System;
using System.Collections.Generic;

namespace Domain.Services
{
    public class EmissoraService : IEmissoraService
    {
        private readonly IEmissoraRepository _repository;
        public EmissoraService(IEmissoraRepository repository)
        {
            _repository = repository;
        }

        public void Add(Emissora emissora)
        {
            if (!EmissoraValidator.ValidaNome(emissora.Nome)){
                throw new Exception("Não é permitido caracter especial no nome da emissora.");
            }

            if (Exists(emissora))
                throw new Exception("Essa emissora já foi cadastrada.");

            _repository.Add(emissora);
        }

        public bool Exists(Emissora audiencia)
        {
            return _repository.Exists(audiencia);
        }

        public List<Emissora> Get()
        {
            return _repository.Get();
        }

        public void Remove(int id)
        {
            Emissora deleteEmissora = _repository.Get(id);
            
            if (deleteEmissora == null)
                throw new Exception("Registro não encontrado.");
            
            _repository.Remove(deleteEmissora);
        }

        public void Update(Emissora audiencia)
        {
            _repository.Update(audiencia);
        }
    }
}
