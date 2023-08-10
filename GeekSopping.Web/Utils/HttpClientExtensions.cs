using System.Net.Http.Headers;
using System.Text.Json;

namespace GeekSopping.Web.Utils
{
    public static class HttpClientExtensions
    {
        private static MediaTypeHeaderValue contentType = new MediaTypeHeaderValue("application/json");

        public static async Task<T> ReadContentAsync<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode) throw new ApplicationException($"something went wrong calling the API: " + $"{response.ReasonPhrase}");

            var dataAsyncString = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(dataAsyncString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true});
        }

        public static Task<HttpResponseMessage> PostAsyncJson<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsyncString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsyncString);
            content.Headers.ContentType = contentType;

            return httpClient.PostAsync(url, content);
        }

        public static Task<HttpResponseMessage> PutAsyncJson<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsyncString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsyncString);
            content.Headers.ContentType = contentType;

            return httpClient.PutAsync(url, content);

        }
    }
}
