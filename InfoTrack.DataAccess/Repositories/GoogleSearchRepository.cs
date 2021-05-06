using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace InfoTrack.DataAccess.Repositories
{
    public class GoogleSearchRepository : IGoogleSearchRepository
    {
        private HttpClient _httpClient;
        public GoogleSearchRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> GetResponse(string keywords)
        {
            var response = await _httpClient.GetAsync($"https://www.google.com/search?num=100&q={HttpUtility.HtmlEncode(keywords)}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return null;
        }
    }
}
