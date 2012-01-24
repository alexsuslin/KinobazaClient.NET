namespace Kinobaza.Api.Objects
{
    public class Credentials
    {
        #region Properties

        public string AccessToken { get; set; }

        #endregion

        #region Constructors

        public Credentials(string accessToken)
        {
            AccessToken = accessToken;
        }

        #endregion
    }
}
