using Newtonsoft.Json;
using RestSharp;
using StoreManage.DTOs.Account;
using StoreManage.DTOs.Token;
using System;
using System.Threading.Tasks;
using System.Linq;



namespace StoreManage.Services
{
    public class ApiService
    {
        private readonly RestClient _client;

        public ApiService()
        {
            var baseUrl = System.Configuration.ConfigurationManager.AppSettings["ApiBaseUrl"];
            _client = new RestClient(baseUrl);
        }

        public async Task<string> LoginAsync(string endpoint , LoginDto loginDto)
        {
            var request = new RestRequest(endpoint, Method.Post);

            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(loginDto);

            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                //var refreshTokenCookie = response.Cookies.AsQueryable();

                return response.Content;
            }

            var errorMessage = response.Content ?? $"API call failed with status: {response.StatusCode}";
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                throw new Exception("Invalid username or password.");
            }

            throw new Exception($"API call failed: {errorMessage}");
        }

        public async Task<T> SignupAsync<T> (string endpoint, object data)
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

        // GET method cho tất cả các model
        public async Task<T> GetAsync<T>(string endpoint, string token = null)
        {
            var request = new RestRequest(endpoint, Method.Get);

            if (!String.IsNullOrEmpty(token))
                request.AddHeader("Authorization", $"Bearer {token}");

            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }

            throw new Exception($"GET failed: {response.StatusCode} - {response.Content}");
        }

        // POST method cho tất cả các model
        public async Task<T> PostAsync<T>(string endpoint, object data, string token = null)
        {
            var request = new RestRequest(endpoint, Method.Post)
                .AddJsonBody(data);

            if (!String.IsNullOrEmpty(token))
                request.AddHeader("Authorization", $"Bearer {token}");

            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }

            throw new Exception($"POST failed: {response.StatusCode} - {response.Content}");
        }

        // PUT method cho tất cả các model
        public async Task<T> PutAsync<T>(string endpoint, object data, string token)
        {
            var request = new RestRequest(endpoint, Method.Put)
                .AddJsonBody(data).AddHeader("Authorization", $"Bearer {token}");

            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }

            throw new Exception($"PUT failed: {response.StatusCode} - {response.Content}");
        }

        // DELETE method cho tất cả các model
        public async Task<bool> DeleteAsync(string endpoint, string token)
        {
            var request = new RestRequest(endpoint, Method.Delete).AddHeader("Authorization", $"Bearer {token}");
            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return true;
            }

            throw new Exception($"DELETE failed: {response.StatusCode} - {response.Content}");
        }
    }
}
