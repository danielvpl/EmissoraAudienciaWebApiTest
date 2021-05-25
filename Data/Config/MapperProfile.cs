using Application.InputModels;
using AutoMapper;
using Domain.Entities;

namespace Data.Config
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AudienciaInputModel, Audiencia>();
            CreateMap<EmissoraInputModel, Emissora>();
        }
    }
}
