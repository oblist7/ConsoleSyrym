namespace Task_10
{
    public class EmployeeReportDirector
    {
        private readonly IEmployeeReportBuilder _builder;

        public EmployeeReportDirector(IEmployeeReportBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder
                .BuilderHeader()
                .BuilderBody()
                .BuilderFooter();
        }
    }
}
