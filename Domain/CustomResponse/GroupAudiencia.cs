using Domain.Entities;
using System;

namespace Domain.CustomResponse
{
    public class GroupAudiencia
    {
        public string Emissora_Nome { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
    }
}
