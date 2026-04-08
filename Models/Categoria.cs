using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiFinanceiro.Models
{
    [Table("categorias")]
    public class Categoria
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("descricao")]
        public required string Descricao { get; set; }

        [JsonIgnore]
        public ICollection<Despesa>? Despesas { get; set; }
    }
}
