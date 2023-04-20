using MyPortifolio.Data;
using MyPortifolio.Data.ViewModel;
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

    public async Task<AboutViewModel> GetAbouts()
    {
        AboutViewModel about = new AboutViewModel
        {
            PersonalInfo = await _httpClient.GetFromJsonAsync<PersonalInfo>("/personalinfos/1"),
            AboutItems = await _httpClient.GetFromJsonAsync<List<AboutItemData>>("/aboutitems"),
            ProgressBars = await _httpClient.GetFromJsonAsync<List<ProgressBarData>>("/progressbars"),
            TimeLines = await _httpClient.GetFromJsonAsync<List<TimeLineItemData>>("/timelines")
        };
        return about;
    }

    public async Task<PersonalInfo> GetPersonalInfo() => await _httpClient.GetFromJsonAsync<PersonalInfo>("/personalinfos/1");

    public async Task<List<PortifolioItemData>> GetPortifolio() => await _httpClient.GetFromJsonAsync<List<PortifolioItemData>>("/portifolios");

    public async Task<List<CertificacaoItemData>> GetCertificacoes() => await _httpClient.GetFromJsonAsync<List<CertificacaoItemData>>("/certificacaos");
}
