using Domain.CustomResponse;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IAudienciaRepository
    {
        void Add(Audiencia audiencia);
        List<Audiencia> Get();
        Audiencia Get(int it);
        void Remove(Audiencia audiencia);
        void Update(Audiencia audiencia);
        bool Exists(Audiencia audiencia);
        List<GroupAudiencia> GetAverage(DateTime dtAudiencia);
        List<GroupAudiencia> GetSummary(DateTime dtAudiencia);
    }
}
