using NSubstitute;
using DotnetMsSqlCICD.Test.Framework;
using DotnetMsSqlCICD.Api.Controllers;
using DotnetMsSqlCICD.Business.Interfaces;


namespace DotnetMsSqlCICD.Test.Api.TeacherControllerSpec
{
    public abstract class UsingTeacherControllerSpec : SpecFor<TeacherController>
    {
        protected ITeacherService _teacherService;

        public override void Context()
        {
            _teacherService = Substitute.For<ITeacherService>();
            subject = new TeacherController(_teacherService);

        }

    }
}
