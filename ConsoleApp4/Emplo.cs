using System.Collections.Specialized;
namespace Lab2_4
{
    internal class Emplo
    {
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployeesFromFile("List.txt");
            List<Employee> sortedSalaryEmployees = employees.OrderByDescending(e => e.Salary).ToList();

            foreach (Employee employee in sortedSalaryEmployees)
            {
                Console.WriteLine("{0} {1}: {2}", employee.FirstName, employee.LastName, employee.Salary);
            }

            static List<Employee> GetEmployeesFromFile(string filePath)
            {
                List<Employee> employees = new List<Employee>();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        Employee employee = new Employee
                        {
                            FirstName = parts[0].Trim(),
                            LastName = parts[1].Trim(),
                            Salary = int.Parse(parts[2])
                        };
                        employees.Add(employee);
                    }
                }
                return employees;

            }

        }
    }
}