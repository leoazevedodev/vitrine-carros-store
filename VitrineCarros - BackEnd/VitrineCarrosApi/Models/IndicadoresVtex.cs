namespace AlphabiApi.Models
{
    public class IndicadoresVtexModel
    {
        public string Chave { get; set; }
        public string Origem { get; set; }
        public int Data { get; set; }
        public string Lojaid { get; set; }
        public string CodigoVendedoraVtex { get; set; }
        public string CodigoVendedoraLinx { get; set; }
        public string Loja { get; set; }
        public string Nome { get; set; }
        public string Canal { get; set; }
        public double ValorTotal { get; set; }
        public double ValorTotalDesconto { get; set; }
        public double ValorTotalMarketplace { get; set; }
        public double ValorTotalFulfillment { get; set; }
        public double Pmv { get; set; }
        public int Quantidade { get; set; }
    }
}
