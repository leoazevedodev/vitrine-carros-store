using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlphabiApi.Data.Models
{
    public class IdentidadeMetasDiariasModel
    {
        [Key]
        public string chave { get; set; }
        public string lojaid { get; set; }
        public string data { get; set; }
        public string periodo { get; set; }
        [Column(TypeName = "decimal(10,3)")]
        public decimal percentual { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal meta { get; set; }
    }
}
