using System.Configuration;

namespace Kinobaza.Test
{
    internal static class Config
    {
        #region Properties
        
        internal static string Username = ConfigurationManager.AppSettings["Username"] ?? "<INSERT USERNAME>";
        internal static string Password = ConfigurationManager.AppSettings["Password"] ?? "<INSERT PASSWORD>";

        #endregion
    }

}
