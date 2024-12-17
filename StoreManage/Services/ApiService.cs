using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;


namespace StoreManage.Services
{
    public class ApiService
    {
        private readonly RestClient _client;

        public ApiService(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        // GET method cho tất cả các model
        public async Task<T> GetAsync<T>(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Get);
            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }

            throw new Exception($"GET failed: {response.StatusCode} - {response.Content}");
        }

        // POST method cho tất cả các model
        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            var request = new RestRequest(endpoint, Method.Post)
                .AddJsonBody(data);

            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }

            throw new Exception($"POST failed: {response.StatusCode} - {response.Content}");
        }

        // PUT method cho tất cả các model
        public async Task<T> PutAsync<T>(string endpoint, object data)
        {
            var request = new RestRequest(endpoint, Method.Put)
                .AddJsonBody(data);

            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }

            throw new Exception($"PUT failed: {response.StatusCode} - {response.Content}");
        }

        // DELETE method cho tất cả các model
        public async Task<bool> DeleteAsync(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Delete);
            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return true;
            }

            throw new Exception($"DELETE failed: {response.StatusCode} - {response.Content}");
        }
    }
}
