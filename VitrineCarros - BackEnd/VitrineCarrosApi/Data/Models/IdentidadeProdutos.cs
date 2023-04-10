using System.ComponentModel.DataAnnotations;

namespace AlphabiApi.Data.Models
{
    public class IdentidadeProdutosModel
    {
        [Key]
        public string microvix { get; set; }
        public string? ean { get; set; }
        public string? protheus { get; set; }
        public string? sku { get; set; }
        public string? barcodes { get; set; }
        public string? codigo_integracao_ws { get; set; }
        public string? ncm { get; set; }
        public string? desativado { get; set; }
        public string descricao { get; set; }
        public string linha { get; set; }
        public string categoria { get; set; }
        public string colecao { get; set; }
        public string grupo { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public string tamanho { get; set; }
        public string referencia { get; set; }
        public string mapa { get; set; }
        public int? quantidade { get; set; }
        public string? coordenado { get; set; }
        public string? system { get; set; }
        public string data_inclusao_linx { get; set; }
        public DateTime data_importacao_integracao { get; set; }
        public string? timestamp { get; set; }
        public double? preco { get; set; }
        public string? foto { get; set; }
        public bool integrar { get; set; }
    }
}
