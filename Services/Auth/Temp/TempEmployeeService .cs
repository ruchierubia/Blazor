using BlazorEmployeeManagement.Models.Temp;
using System.Xml.Linq;

namespace BlazorEmployeeManagement.Services.Auth.Temp
{
    // TEMPORARY:
    // Uses in-memory employee data until the real application
    // boundary is introduced.
    public class TempEmployeeService : ITempEmployeeService
    {
        private readonly List<TempEmployee> _employees =
        [
            new TempEmployee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Smith",
            Email = "john.smith@example.com",
            Department = "IT"
        },
        new TempEmployee
        {
            Id = 2,
            FirstName = "Sarah",
            LastName = "Johnson",
            Email = "sarah.johnson@example.com",
            Department = "Human Resources"
        },
        new TempEmployee
        {
            Id = 3,
            FirstName = "Michael",
            LastName = "Brown",
            Email = "michael.brown@example.com",
            Department = "Finance"
        }
        ];

        public List<TempEmployee> GetEmployees()
        {
            return _employees;
        }

        public TempEmployee? GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(employee => employee.Id == id);
        }

        public void AddEmployee(TempEmployee employee)
        {
            employee.Id = _employees.Count == 0
                ? 1
                : _employees.Max(employee => employee.Id) + 1;

            _employees.Add(employee);
        }

        public void UpdateEmployee(TempEmployee employee)
        {
            var existingEmployee = GetEmployeeById(employee.Id);

            if (existingEmployee is null)
            {
                return;
            }

            existingEmployee.FirstName = employee.FirstName;
            existingEmployee.LastName = employee.LastName;
            existingEmployee.Email = employee.Email;
            existingEmployee.Department = employee.Department;
        }

        public void DeleteEmployee(int id)
        {
            var employee = GetEmployeeById(id);

            if (employee is not null)
            {
                _employees.Remove(employee);
            }
        }
    }
}
