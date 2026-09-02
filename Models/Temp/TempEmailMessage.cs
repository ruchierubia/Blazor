namespace BlazorEmployeeManagement.Models.Temp;

// TEMPORARY:
// Represents an email that needs to be processed.
public class TempEmailMessage
{
    public string To { get; set; } = string.Empty;

    public string Subject { get; set; } = string.Empty;

    public string Body { get; set; } = string.Empty;
}