using NSubstitute;
using DotnetMsSqlCICD.Test.Framework;
using DotnetMsSqlCICD.Business.Services;
using DotnetMsSqlCICD.Data.Interfaces;

namespace DotnetMsSqlCICD.Test.Business.TeacherServiceSpec
{
    public abstract class UsingTeacherServiceSpec : SpecFor<TeacherService>
    {
        protected ITeacherRepository _teacherRepository;

        public override void Context()
        {
            _teacherRepository = Substitute.For<ITeacherRepository>();
            subject = new TeacherService(_teacherRepository);

        }

    }
}
