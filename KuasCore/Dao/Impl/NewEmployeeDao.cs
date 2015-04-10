using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using KuasCore.Models;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employees1 = new Employee();
            employees1.Id = "Lala";
            employees1.Name = "拉拉";
            employees1.Age = 1;
            employees.Add(employees1);

            Employee employees2 = new Employee();
            employees2.Id = "Bear";
            employees2.Name = "熊大";
            employees2.Age = 10;
            employees.Add(employees2);

            return employees;
        
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employees = new Employee();
            employees.Id = "Bear";
            employees.Name = "熊大";
            employees.Age = 10;

            return employees;
        
        
        }

    }
}
