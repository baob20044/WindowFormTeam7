using Newtonsoft.Json;
using RestSharp;
using StoreManage.DTOs.Account;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using System.Net;



namespace StoreManage.Services
{
    public class ApiService
    {
        private readonly RestClient _client;
        private readonly CookieContainer _cookieContainer;
        public ApiService()
        {
            var baseUrl = System.Configuration.ConfigurationManager.AppSettings["ApiBaseUrl"];

            _cookieContainer = new CookieContainer();

            var options = new RestClientOptions(baseUrl)
            {
                CookieContainer = _cookieContainer
            };

            _client = new RestClient(options);
        }

        public async Task<string> LoginAsync(string endpoint , LoginDto loginDto)
        {
            var request = new RestRequest(endpoint, Method.Post);

            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(loginDto);

            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                foreach (Cookie cookie in _cookieContainer.GetCookies(new Uri("https://localhost:5254")))
                {
                    if (cookie.Name == "refreshToken")
                        TokenManager.SaveRefreshToken(cookie.Value);
                }
                return response.Content;
            }

            var errorMessage = response.Content ?? $"API call failed with status: {response.StatusCode}";
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                throw new Exception($"{errorMessage}");
            }

            throw new Exception($"API call failed: {errorMessage}");
        }

        public async Task<string> SignupAsync(string endpoint, object data)
        {
            var request = new RestRequest(endpoint, Method.Post)
               .AddJsonBody(data);

            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return response.Content;
            }

            var errorMessage = response.Content ?? $"API call failed with status: {response.StatusCode}";
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                throw new Exception($"{errorMessage}");
            }

            throw new Exception($"POST failed: {response.StatusCode} - {response.Content}");
        }

        //GET method cho tất cả các model
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
        public async Task<T> PostAsync<T>(string endpoint, object data = null, string token = null)
        {
            var request = new RestRequest(endpoint, Method.Post);

            if (data != null)
                request.AddJsonBody(data);
            else
                request.AddHeader("Cookie", $"refreshToken={TokenManager.GetRefreshToken()}");

            if (!String.IsNullOrEmpty(token))
                request.AddHeader("Authorization", $"Bearer {token}");

            Console.WriteLine("Request Headers:");
            foreach (var header in request.Parameters.Where(p => p.Type == ParameterType.HttpHeader))
            {
                Console.WriteLine($"{header.Name}: {header.Value}");
            }

            var response = await _client.ExecuteAsync(request);

            

            if (response.IsSuccessful)
            {
                if (data == null)
                {
                    foreach (Cookie cookie in _cookieContainer.GetCookies(new Uri("https://localhost:5254")))
                    {
                        if (cookie.Name == "refreshToken")
                            TokenManager.SaveRefreshToken(cookie.Value);
                    }
                }    
                return JsonConvert.DeserializeObject<T>(response.Content);
            }

            throw new Exception($"POST failed: {response.StatusCode} - {response.Content}");
        }

        // PUT method cho tất cả các model
        public async Task<T> PutAsync<T>(string endpoint, object data, string token)
        {
            var request = new RestRequest(endpoint, Method.Put).
               AddHeader("Authorization", $"Bearer {token}").AddJsonBody(data);

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
