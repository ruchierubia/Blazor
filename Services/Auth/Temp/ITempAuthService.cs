using BlazorEmployeeManagement.Models.Temp;

namespace BlazorEmployeeManagement.Services.Auth.Temp
{
    // TEMPORARY:
    // Replace this abstraction when the real application/authentication boundary is introduced.
    public interface ITempAuthService
    {
        TempUser? ValidateUser(string username, string password);
    }
}
