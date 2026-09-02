using BlazorEmployeeManagement.Services.Email;

namespace BlazorEmployeeManagement.Services.Email.Temp;

// TEMPORARY:
// Background worker that consumes emails from the
// in-memory queue and sends them.
public class TempEmailBackgroundService : BackgroundService
{
    private readonly IEmailQueue _emailQueue;
    private readonly IEmailSender _emailSender;

    public TempEmailBackgroundService(
        IEmailQueue emailQueue,
        IEmailSender emailSender)
    {
        _emailQueue = emailQueue;
        _emailSender = emailSender;
    }

    protected override async Task ExecuteAsync(
        CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var email = await _emailQueue.DequeueAsync(
                stoppingToken);

            await _emailSender.SendAsync(
                email,
                stoppingToken);
        }
    }
}