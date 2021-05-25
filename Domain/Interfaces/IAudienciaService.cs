using Domain.CustomResponse;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IAudienciaService
    {
        void Add(Audiencia audiencia);
        List<Audiencia> Get();
        void Remove(int id);
        void Update(Audiencia audiencia);
        bool Exists(Audiencia audiencia);
        List<GroupAudiencia> GetAverage(DateTime dtAudiencia);
        List<GroupAudiencia> GetSummary(DateTime dtAudiencia);
    }
}
