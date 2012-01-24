using Kinobaza.Api;
using Kinobaza.Api.Constants;
using Kinobaza.Api.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShows.Api;

namespace Kinobaza.Test
{
    [TestClass]
    public class ApiTests
    {
        private readonly Credentials credentials;
        private readonly Credentials wrongCredentials;
        private readonly KinobazaClient Client;
        private readonly KinobazaClient InvalidClient;

        public ApiTests()
        {
            credentials = new Credentials(Config.AccessToken);
            wrongCredentials = new Credentials("wrongtoken");
            Client = new KinobazaClient(credentials);
            InvalidClient = new KinobazaClient(wrongCredentials);
        }

        [TestInitialize]
        public void StartUp()
        {
            //Client.Auth(credentials);
        }

        [TestMethod]
        public void BrowseFilms()
        {
            KinobazaResponse response;
            
            response = Client.FilmsBrowse();
            Assert.AreEqual(response.Status, Status.Success);
//
//            response = Client.Auth(wrongCredentials);
//            Assert.AreEqual(response.Status, Status.InvalidCredentials);
//
//            response = Client.Auth(new Credentials(string.Empty, string.Empty));
//            Assert.AreEqual(response.Status, Status.NotFound);
        }
      
    }
}
