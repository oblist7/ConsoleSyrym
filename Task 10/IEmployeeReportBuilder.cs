namespace Task_10
{
    public interface IEmployeeReportBuilder
    {
        IEmployeeReportBuilder BuilderHeader();

        IEmployeeReportBuilder BuilderBody();

        IEmployeeReportBuilder BuilderFooter();

        EmployeeReport GetReport();
    }
}
