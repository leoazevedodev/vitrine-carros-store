namespace AlphabiApi.Models
{
    public class IndicadoresAlphabiModel
    {
        public string Chave { get; set; }
        public string Lojaid { get; set; }
        public string Loja { get; set; }
        public string UF { get; set; }
        public int Data { get; set; }
        public double ValorTotal { get; set; }
        public double ValorTotalApp { get; set; }
        public double ValorTotalLoja { get; set; }
        public double ValorTotalAnoPassado { get; set; }
        public double Pmv { get; set; }
        public double PmvAnoPassado { get; set; }
        public double TicketMedio { get; set; }
        public double TicketMedioAnoPassado { get; set; }
        public double Pa { get; set; }
        public double PaAnoPassado { get; set; }
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
