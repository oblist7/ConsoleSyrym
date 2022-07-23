/*
 * Task 10 Ввывести отчет зарплаты сотрудников используя Builder
 * Design Patterns
 * 
 * Result:
 * Employee Report on date: 7/23/2022 1:53:02 PM
 * --------------------------------------------------
 * Employee: Syrym Salary: 1000$
 * Employee: Ivan  Salary: 1100$
 * Employee: Arman Salary: 1090$
 * --------------------------------------------------
 * 
 * Total Employees: 3,Total Salary: 3190$
 * 
 */

using Task_10;

List<Employee> employees = new()
{
    new Employee { Name = "Syrym", Salary = 1000 },
    new Employee { Name = "Ivan", Salary = 1100 },
    new Employee { Name = "Arman", Salary = 1090 }
};

var builder = new EmployeeReportBuilder(employees);

var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

Console.WriteLine(report);
Console.ReadLine();
