namespace MyPortifolio.Data;

public record PersonalInfo(
    string FirstName,
    string LastName,
    string Carrer,
    string Intro,
    string Description
    )
{
    public string FullName { get; set; } = FirstName + " " + LastName;
}
