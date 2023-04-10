namespace VitrineCarrosApi.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string pais { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public bool status { get; set; }
        public string permissao { get; set; }
        public DateTime create { get; set; }
        public DateTime update { get; set; }
    }
}
