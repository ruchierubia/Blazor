namespace BlazorEmployeeManagement.Models.Temp
{
    // TEMPORARY:
    // Used until the real application authentication request/command
    // boundary is introduced.
    public class TempLoginRequest
    {
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
