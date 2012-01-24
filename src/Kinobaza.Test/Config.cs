using System.Configuration;

namespace Kinobaza.Test
{
    internal static class Config
    {
        #region Properties

        internal static string AccessToken = ConfigurationManager.AppSettings["SecurityToken"] ?? "<INSERT TOKEN>";

        #endregion
    }

}
