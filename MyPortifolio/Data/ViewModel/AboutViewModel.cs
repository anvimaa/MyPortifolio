using MyPortifolio.Services;

namespace MyPortifolio.Data.ViewModel;

public class AboutViewModel
{
    public PersonalInfo? PersonalInfo { get; set; } = RepositoryData.PersonalInfo;
    public List<AboutItemData>? AboutItems { get; set; } = RepositoryData.AboutItems;
    public List<ProgressBarData>? ProgressBars { get; set; } = RepositoryData.ProgressBars;
    public List<TimeLineItemData>? TimeLines { get; set; } = RepositoryData.TimeLineItems;
}
