namespace VitrineCarrosApi.Settings
{
    public class Connections
    {
        public static string? vtex { get; set; }
        public static string? alphabi { get; set; }
        public static string? alphadev { get; set; }
        public static string? identidadeacesso { get; set; }

        public static void Start(IConfiguration configuration)
        {
            vtex = configuration.GetConnectionString("Vtex");
            alphabi = configuration.GetConnectionString("Alphabi");
            alphadev = configuration.GetConnectionString("AlphaDev");
            identidadeacesso = configuration.GetConnectionString("Identity");
        }
    }
}
