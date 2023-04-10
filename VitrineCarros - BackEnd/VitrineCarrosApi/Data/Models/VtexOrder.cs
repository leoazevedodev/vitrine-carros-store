using System.ComponentModel.DataAnnotations;

namespace AlphabiApi.Data.Models
{
#nullable enable
    public class VtexOrderModel
    {
        [Key]
        public string? OrderId { get; set; }
        public string? ClienteId { get; set; }
        public string? Sequence { get; set; }
        public string? Origem { get; set; }
        public string? Status { get; set; }
        public Decimal ValorTotalPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public Decimal ValorPedido { get; set; }
        public Decimal ValorDesconto { get; set; }
        public string? VendedoraId { get; set; }
        public string? Coupon { get; set; }
        public string? UtmSource { get; set; }
        public string? Transportadora { get; set; }
        public DateTime? DataFaturamento { get; set; }
        public string? NotaFiscal { get; set; }
    }
}
