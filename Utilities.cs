namespace SMT_Web_Form
{
    public class Utilities
    {
        public string GetConnectionString()
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/SMT Web Form");
            string ConnString = rootWebConfig.ConnectionStrings.ConnectionStrings["Conn_String"].ConnectionString;
            return ConnString;

        }
    }
}