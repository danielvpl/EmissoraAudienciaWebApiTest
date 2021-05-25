using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Audiencia
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double Pontos_audiencia { get; set; }
        public DateTime Data_hora_audiencia { get; set; }
        public int Emissora_audienciaId { get; set; }
        public Emissora Emissora_audiencia { get; set; }
    }
}
