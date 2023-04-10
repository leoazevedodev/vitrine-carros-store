using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlphabiApi.Data.Models
{
#nullable enable
    public class AlphabiIndicadoresModel
    {
        [Key]
        public string Chave { get; set; }
        public string Lojaid { get; set; }
        public string Loja { get; set; }
        public string UF { get; set; }
        public string Canal { get; set; }
        public string Data { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorTotal { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorTotalApp { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorTotalLoja { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorTotalAnoPassado { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Pmv { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PmvAnoPassado { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal TicketMedio { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal TicketMedioMedioAnoPassado { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Pa { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PaAnoPassado { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeAnoPassado { get; set; }
        public int NumeroVendas { get; set; }
        public int NumeroVendasAnoPassado { get; set; }
        public int ClientesAssociados { get; set; }
        public int ClientesAssociadosAnoPassado { get; set; }
        public double CustoTotal { get; set; }
        public double CustoTotalAnoPassado { get; set; }
        public double MetaDia { get; set; }
        public double MetaDiaAnoPassado { get; set; }
        public double MetaMes { get; set; }
        public double MetaMesAnoPassado { get; set; }
    }
}
