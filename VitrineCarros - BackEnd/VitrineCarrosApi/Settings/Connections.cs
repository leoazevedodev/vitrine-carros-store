namespace VitrineCarrosApi.Settings
{
    public class Connections
    {
        public static string connection { get; set; }

        public static void Start(IConfiguration configuration)
        {
            connection = configuration.GetConnectionString("Vitrine");
        }
    }
}
