using BlazorEmployeeManagement.Models.Temp;

namespace BlazorEmployeeManagement.Services.Email
{
    public interface IEmailSender
    {

        Task SendAsync(TempEmailMessage email, CancellationToken cancellationToken);
    }
}
