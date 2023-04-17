using MyPortifolio.Data;

namespace MyPortifolio.Services;
public class AppService
{
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
}
