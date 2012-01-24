namespace Kinobaza.Api.Constants
{
    public enum Status
    {
        /// <summary>
        /// Request was successful
        /// </summary>
        Success = 200,

        /// <summary>
        /// Username and/or Password is incorrect, authorization required
        /// </summary>
        AuthorizationRequired = 401,

        /// <summary>
        /// Access is Denied
        /// </summary>
        Forbidden = 403,

        /// <summary>
        /// Document is not found
        /// </summary>
        NotFound = 404,

        /// <summary>
        /// Ivalid request, e.g. you used GET instead of POST
        /// </summary>
        InvalidRequest = 405,

        /// <summary>
        /// The number of requests per second exceeded
        /// </summary>
        LimitExceeded = 503
    }
}
