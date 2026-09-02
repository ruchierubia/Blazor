using BlazorEmployeeManagement.Models.Temp;

namespace BlazorEmployeeManagement.Services.Email
{
    public interface IEmailQueue
    {

        ValueTask QueueAsync(TempEmailMessage email);

        ValueTask<TempEmailMessage> DequeueAsync(CancellationToken cancellationToken);
    }
}
