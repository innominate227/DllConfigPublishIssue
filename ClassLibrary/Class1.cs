using System.Configuration;

namespace ClassLibrary
{
    public class Class1
    {
        public static string Test()
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(typeof(Class1).Assembly.Location);
            return configuration.AppSettings.Settings["Test"].Value;
        }
    }
}