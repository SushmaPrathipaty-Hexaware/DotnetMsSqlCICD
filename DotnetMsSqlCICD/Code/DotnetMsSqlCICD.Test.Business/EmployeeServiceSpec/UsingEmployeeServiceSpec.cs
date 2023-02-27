using NSubstitute;
using DotnetMsSqlCICD.Test.Framework;
using DotnetMsSqlCICD.Business.Services;
using DotnetMsSqlCICD.Data.Interfaces;

namespace DotnetMsSqlCICD.Test.Business.EmployeeServiceSpec
{
    public abstract class UsingEmployeeServiceSpec : SpecFor<EmployeeService>
    {
        protected IEmployeeRepository _employeeRepository;

        public override void Context()
        {
            _employeeRepository = Substitute.For<IEmployeeRepository>();
            subject = new EmployeeService(_employeeRepository);

        }

    }
}
