using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace ExamenProgra6Assents_JozefMA.Models
{
    internal class AskStatus
    {

        public RestRequest request { get; set; }
        const string mimeType = "application/json";
        const string contentType = "Content-Type";

        public int AskStatusID { get; set; }

        public string AskStatusDescription { get; set; } = null!;

        public async Task<List<AskStatus>?> GetAllAskStatusAsync()
        {
            try
            {

                string RouterSufix = string.Format("AskStatus");

                string URL = Services.WebAPIConnection.ProductionURLPrefix + RouterSufix;

                var client = new RestClient(URL);

                request = new RestRequest(URL, Method.Get);

                request.AddHeader(Services.WebAPIConnection.ApiKeyName,
                                  Services.WebAPIConnection.ApiKeyValue);

                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    var list = JsonConvert.DeserializeObject<List<AskStatus>>(response.Content);

                    return list;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                string ErrorMsg = ex.Message;
                throw;
            }

        }

    }
}
