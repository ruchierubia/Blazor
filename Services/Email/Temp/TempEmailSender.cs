using BlazorEmployeeManagement.Models.Temp;

namespace BlazorEmployeeManagement.Services.Email.Temp;

// TEMPORARY:
// Simulates sending an email.
// No real email provider is used.
public class TempEmailSender : IEmailSender
{
    public Task SendAsync(
        TempEmailMessage email,
        CancellationToken cancellationToken)
    {
        Console.WriteLine("=================================");
        Console.WriteLine("TEMP EMAIL SENT");
        Console.WriteLine($"To: {email.To}");
        Console.WriteLine($"Subject: {email.Subject}");
        Console.WriteLine($"Body: {email.Body}");
        Console.WriteLine("=================================");

        return Task.CompletedTask;
    }
}