
using System.ComponentModel.DataAnnotations;

namespace AlphabiApi.Data.Models
{
#nullable enable
    public class AlphabiFatoVendaModel
    {
        public string? fato_venda_fantasia { get; set; }
        [Key]
        public string? fato_venda_lojaid { get; set; }
        public string fato_venda_venda_data { get; set; }
        public int? fato_venda_quantidade { get; set; }
        public double fato_venda_venda { get; set; }
        public string? fato_venda_vendedor_nome { get; set; }
        public string? fato_venda_isvendedor { get; set; }
        public string? fato_venda_canal { get; set; }
        public string? fato_venda_hora { get; set; }
        public string? fato_venda_prodid { get; set; }
        public string? fato_venda_identificador { get; set; }
        public string? fato_venda_uf { get; set; }
        public string? fato_venda_integracao { get; set; }
        public string? fato_venda_clienteid { get; set; }
        public string? fato_venda_sistema { get; set; }
        public int? fato_venda_rotina_origem { get; set; }
        public double? fato_venda_frete { get; set; }
        public string? fato_venda_modalidade { get; set; }
        public string? fato_venda_pedido { get; set; }
        public string? fato_venda_vendedor_vtex { get; set; }
        public string? fato_venda_canal_de_venda { get; set; }

    }
}
