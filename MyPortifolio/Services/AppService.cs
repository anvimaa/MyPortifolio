using MyPortifolio.Data;
using System.Net.Http;

namespace MyPortifolio.Services;
public class AppService
{
    public HttpClient _httpClient;
    public ILogger<AppService> _logger;

    public AppService(HttpClient httpClient, ILogger<AppService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public Task<List<ControlData>> GetControls()
    {
        List<ControlData> controls = new List<ControlData>
        {
            new ControlData("", "fas fa-home"),
            new ControlData("about", "fas fa-user"),
            new ControlData("portifolio", "fas fa-briefcase"),
            new ControlData("certificacoes", "fas fa-newspaper"),
            new ControlData("contact", "fas fa-envelope-open"),
        };
        return Task.FromResult(controls);
    }

    public async Task<PersonalInfo> GetPersonalInfo()
    {

        return await _httpClient.GetFromJsonAsync<PersonalInfo>("/personalinfos/1");
    }
}
