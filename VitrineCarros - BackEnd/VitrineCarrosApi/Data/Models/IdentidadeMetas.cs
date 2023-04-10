using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlphabiApi.Data.Models
{
    public class IdentidadeMetasModel
    {
        [Key]
        public string chave { get; set; }
        public string lojaid { get; set; }
        public string loja { get; set; }
        public string anomes { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal metafisica { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal metaonline { get; set; }
        public int metapeca { get; set; }
        public int usuario_id { get; set; }
        public DateTime updated { get; set; }
        public DateTime created { get; set; }
    }
}
