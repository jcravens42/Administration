using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Administration.Models
{
    public class MockEmployeeRepository : iEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {   new Employee() {Id=1, Name="Mary", Department=Dept.HR, Email="mary@pragim.com" },
            new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@pragim.com" },
            new Employee() { Id = 3, Name = "Sam", Department = Dept.Payroll, Email = "sam@pragim.com" }

            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
