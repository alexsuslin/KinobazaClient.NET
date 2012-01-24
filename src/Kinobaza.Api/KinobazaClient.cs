using Kinobaza.Api.Constants;
using Kinobaza.Api.Objects;
using RestSharp;

namespace Kinobaza.Api
{
    public class KinobazaClient
    {
        #region Fields & Consts

        public const string BaseUrl = "http://api.kinobaza.tv/";

        public const string SignatureMethod = "PLAINTEXT";

        public const string RequestTokenUri = "http://api.kinobaza.tv/auth/request-token";
        public const string AuthorizeUri = "http://api.kinobaza.tv/auth/authorize";
        public const string AccessTokenUri = "http://api.kinobaza.tv/auth/access-token";

        private readonly string ApiUrl;

        #endregion

        #region Properties

        public Credentials Credentials { get; set; }

        #endregion

        #region Constructors

        public KinobazaClient(Credentials credentials = null, string baseUrl = BaseUrl)
        {
            ApiUrl = baseUrl;
            Credentials = credentials;
        }

        #endregion

        #region Methods


        #endregion

        #region Helper Methods


        private KinobazaResponse Execute(RestRequest request)
        {
            RestClient client = new RestClient(ApiUrl);
            request = RequestSetup(client, request);
            return new KinobazaResponse(client.Execute(request));
        }

        private KinobazaResponse<T> Execute<T>(RestRequest request, Credentials cred = null) where T : new()
        {
            RestClient client = new RestClient(ApiUrl);
            request = RequestSetup(client, request);
            return new KinobazaResponse<T>(client.Execute<T>(request));
        }

        private RestRequest RequestSetup(RestClient client, RestRequest request)
        {
            client.Authenticator = new OAuth2UriQueryParameterAuthenticator(Credentials.AccessToken);
            request.Method = Method.POST;
            request.RequestFormat = DataFormat.Json;
            return request;
        }

        #endregion

        public KinobazaResponse FilmsBrowse()
        {
            RestRequest request = new RestRequest(Methods.FilmsBrowse);
            return Execute(request);
        }
    }
}
