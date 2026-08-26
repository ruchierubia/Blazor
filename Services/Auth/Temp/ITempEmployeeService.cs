using BlazorEmployeeManagement.Models.Temp;

namespace BlazorEmployeeManagement.Services.Auth.Temp
{
    // TEMPORARY:
    // Defines employee data operations until the real application
    // boundary is introduced.
    public interface ITempEmployeeService
    {
        List<TempEmployee> GetEmployees();

        TempEmployee? GetEmployeeById(int id);

        void AddEmployee(TempEmployee employee);

        void UpdateEmployee(TempEmployee employee);

        void DeleteEmployee(int id);
    }
}
