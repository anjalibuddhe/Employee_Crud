using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeCURD employeeCURD = new EmployeeCURD();

            int option = 0;
            do
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employeee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Display All Employee");
                int op = Convert.ToInt32(Console.ReadLine());

             

                    switch (op)
                    {
                        case 1:
                            // Add product

                            Employee employee = new Employee();
                            Console.WriteLine("Enter Employee Id");
                            employee.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name");
                            employee.empname = Console.ReadLine();
                            Console.WriteLine("Enter Employee salary");
                            employee.salary = Convert.ToDouble(Console.ReadLine());

                            employeeCURD.AddEmployee(employee);
                            break;

                        case 2:
                            //update
                          Employee employee1=new Employee();
                          Console.WriteLine("Enter Employee id to modify");
                          employee1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        employee1.empname = Console.ReadLine();
                        Console.WriteLine("Enter Employee salary");
                        employee1.salary = Convert.ToDouble(Console.ReadLine());
                        employeeCURD.UpdateEmployee(employee1);
                        break;
                        case 3:
                            //delete
                            Console.WriteLine("Enter id to delete");
                            int id = Convert.ToInt32(Console.ReadLine());
                            employeeCURD.DeleteEmployee(id);
                            break;
                        case 4:
                        // Display all products

                        List<Employee> employees = employeeCURD.GetEmployees();
                            foreach (Employee e in employees)
                            {
                                Console.WriteLine($"{e.Id}--> {e.empname} --> {e.salary}");
                            }
                            break;
                    }

                    Console.WriteLine("Press 1 for Continue");
                    option = Convert.ToInt32(Console.ReadLine());

                }
                while (option == 1);
















                //case 1:
                //    Employee employee = new Employee();
                //    Console.WriteLine("Enter Employee Id");
                //    employee.Id = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("Enter Employee Name");
                //    employee.empname = Console.ReadLine();
                //    Console.WriteLine("Enter Employee salary");
                //    employee.salary = Convert.ToDouble(Console.ReadLine());

                //    employeeCURD.AddEmployee(employee);

            }
    }
}
