using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IEmissoraRepository
    {
        void Add(Emissora emissora);
        List<Emissora> Get();
        Emissora Get(int id);
        void Remove(Emissora emissora);
        void Update(Emissora emissora);
        bool Exists(Emissora emissora);
    }
}
