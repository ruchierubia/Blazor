using BlazorEmployeeManagement.Models.Temp;

namespace BlazorEmployeeManagement.Services.Auth.Temp
{
    // TEMPORARY:
    // Uses in-memory users until the real application/authentication
    // boundary is introduced.
    public class TempAuthService : ITempAuthService
    {
        private readonly List<TempUser> _users =
        [
            new TempUser
        {
            Id = 1,
            Username = "admin",
            Password = "admin123",
            DisplayName = "Administrator",
            Role = "Administrator"
        },
        new TempUser
        {
            Id = 2,
            Username = "employee",
            Password = "employee123",
            DisplayName = "Employee User",
            Role = "Employee"
        }
        ];

        public TempUser? ValidateUser(string username, string password)
        {
            return _users.FirstOrDefault(user =>
                user.Username == username &&
                user.Password == password);
        }
    }
}
