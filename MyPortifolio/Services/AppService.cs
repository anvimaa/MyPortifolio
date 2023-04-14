using MyPortifolio.Data;

namespace MyPortifolio.Services;
public class AppService
{
    public Task<List<ControlData>> GetControls()
    {
        List<ControlData> controls = new List<ControlData>
        {
            new ControlData("", "fa-home", false),
            new ControlData("about", "fa-user", false),
            new ControlData("portifolio", "fa-briefcase", false),
            new ControlData("blogs", "fa-newspaper", false),
            new ControlData("contact", "fa-envelope-open", false),
        };
        return Task.FromResult(controls);
    }
}
