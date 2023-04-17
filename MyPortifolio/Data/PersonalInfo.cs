namespace MyPortifolio.Data;

public record PersonalInfo(
    string FirtName,
    string LastName,
    string Carrer,
    string Intro,
    string Description
    )
{
    public string FullName { get; set; } = FirtName + " " + LastName;
}
