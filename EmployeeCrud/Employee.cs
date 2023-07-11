using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrud
{
    public class Employee
    {
        public int Id { get; set; }
        public string empname { get; set; }
        public double salary { get; set; }
    }
    public class EmployeeCURD
    {
        private List<Employee> employees;

        public EmployeeCURD()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee emp) {
        
        employees.Add(emp);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }


        public void UpdateEmployee(Employee emp)
        {
            foreach (Employee emp1 in employees)
            {
                if (emp1.Id == emp.Id)
                {
                    emp1.empname = emp.empname;
                    emp1.salary = emp.salary;
                    break;
                }
            }
        }
            public void DeleteEmployee(int id)
            {
            foreach(Employee e in employees) { 
                if (e.Id == id)
                {
                    employees.Remove(e);
                    break;
                }
            }

            }


        }
    }

