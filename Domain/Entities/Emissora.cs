using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Emissora
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
