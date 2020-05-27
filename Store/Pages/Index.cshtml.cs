using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Store.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HttpClient _client;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _client = httpClientFactory.CreateClient("pricing");
        }

        public string[] Values { get; set; }

        public async Task OnGet()
        {
            var response = await _client.GetAsync("/api/values");
            var content = await response.Content.ReadAsStringAsync();
            Values = JsonConvert.DeserializeObject<string[]>(content);
        }
    }
}
