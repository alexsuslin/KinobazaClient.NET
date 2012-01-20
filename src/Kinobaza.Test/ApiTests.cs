using Kinobaza.Api.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShows.Api;
using MyShows.Api.Objects;

namespace Kinobaza.Test
{
    [TestClass]
    public class ApiTests
    {
        private readonly Credentials credentials;
        private readonly Credentials wrongCredentials;
        private readonly MyShowsClient Client;
        private readonly MyShowsClient InvalidClient;

        public ApiTests()
        {
            credentials = new Credentials(Config.Username, Config.Password);
            wrongCredentials = new Credentials("wrongusername", "wrongpassword");
            Client = new MyShowsClient(credentials);
            InvalidClient = new MyShowsClient(wrongCredentials);
        }

        [TestInitialize]
        public void StartUp()
        {
            //Client.Auth(credentials);
        }

        [TestMethod]
        public void Auth()
        {
//            KinobazaResponse response;
//            
//            response = Client.Auth(credentials);
//            Assert.AreEqual(response.Status, Status.Success);
//
//            response = Client.Auth(wrongCredentials);
//            Assert.AreEqual(response.Status, Status.InvalidCredentials);
//
//            response = Client.Auth(new Credentials(string.Empty, string.Empty));
//            Assert.AreEqual(response.Status, Status.NotFound);
        }
      
    }
}
