namespace BlazorEmployeeManagement.Models.Temp
{
    // TEMPORARY:
    // Used until the real employee domain model is introduced.
    public class TempEmployee
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;
    }
}
