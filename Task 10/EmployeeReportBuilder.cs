namespace Task_10
{
    public class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport;

        private readonly IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new EmployeeReport();
        }

        public IEmployeeReportBuilder BuilderHeader()
        {
            _employeeReport.Header =
                $"Employee Report on date: {DateTime.Now}\n" +
                "\n----------------------------------------------------------------------------------------------------\n";

            return this;
        }

        public IEmployeeReportBuilder BuilderBody()
        {
            _employeeReport.Body =
                string.Join(Environment.NewLine,
                    _employees.Select(e =>
                    $"Employee: {e.Name}\tSalary: {e.Salary}$"));

            return this;
        }

        public IEmployeeReportBuilder BuilderFooter()
        {
            _employeeReport.Footer =
                "\n----------------------------------------------------------------------------------------------------\n" +
                $"\nTotal Employees: {_employees.Count()}," +
                $"Total Salary: {_employees.Sum(e => e.Salary)}$";

            return this;
        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;

            _employeeReport = new();

            return employeeReport;
        }
    }
}
