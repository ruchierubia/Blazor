namespace BlazorEmployeeManagement.Models.Temp
{
    // TEMPORARY:
    // This model is used until the real application/domain model boundary is introduced.
    public class TempUser
    {
        public int Id { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string DisplayName { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;
    }
}
