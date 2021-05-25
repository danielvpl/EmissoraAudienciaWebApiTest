using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IEmissoraService
    {
        void Add(Emissora emissora);
        List<Emissora> Get();        
        void Remove(int id);
        void Update(Emissora emissora);
        bool Exists(Emissora emissora);
    }
}
