using NSubstitute;
using DotnetMsSqlCICD.Test.Framework;
using DotnetMsSqlCICD.Api.Controllers;
using DotnetMsSqlCICD.Business.Interfaces;


namespace DotnetMsSqlCICD.Test.Api.EmployeeControllerSpec
{
    public abstract class UsingEmployeeControllerSpec : SpecFor<EmployeeController>
    {
        protected IEmployeeService _employeeService;

        public override void Context()
        {
            _employeeService = Substitute.For<IEmployeeService>();
            subject = new EmployeeController(_employeeService);

        }

    }
}
