using NSubstitute;
using DotnetMsSqlCICD.Test.Framework;
using DotnetMsSqlCICD.Api.Controllers;
using DotnetMsSqlCICD.Business.Interfaces;


namespace DotnetMsSqlCICD.Test.Api.StudentControllerSpec
{
    public abstract class UsingStudentControllerSpec : SpecFor<StudentController>
    {
        protected IStudentService _studentService;

        public override void Context()
        {
            _studentService = Substitute.For<IStudentService>();
            subject = new StudentController(_studentService);

        }

    }
}
