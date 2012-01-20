using System;
using System.Collections.Generic;
using System.Linq;
using Kinobaza.Api.Objects;
using MyShows.Api.Objects;
using RestSharp;

namespace MyShows.Api
{
    public class MyShowsClient
    {
        #region Fields & Consts

        public const string BaseUrl = "";

        private readonly string ApiUrl;

        private string phpSessId;

        #endregion

        #region Properties

        public Credentials Credentials { get; set; }

        #endregion

        #region Constructors

        public MyShowsClient(Credentials credentials = null, string baseUrl = BaseUrl)
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
            request = RequestSetup(request);
            return new KinobazaResponse(client.Execute(request));
        }

        private KinobazaResponse<T> Execute<T>(RestRequest request, Credentials cred = null) where T : new()
        {
            RestClient client = new RestClient(ApiUrl);
            request = RequestSetup(request);
            return new KinobazaResponse<T>(client.Execute<T>(request));
        }

        private RestRequest RequestSetup(RestRequest request)
        {
            //request.Resource = !request.Resource.EndsWith(".php") ? string.Format("{0}.php", request.Resource) : request.Resource;
            request.Method = Method.POST;
            request.RequestFormat = DataFormat.Json;
            return request;
        }

        #endregion
    }
}
