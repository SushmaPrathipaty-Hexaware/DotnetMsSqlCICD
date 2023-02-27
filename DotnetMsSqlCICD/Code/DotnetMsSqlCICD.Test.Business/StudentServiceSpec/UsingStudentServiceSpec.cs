using NSubstitute;
using DotnetMsSqlCICD.Test.Framework;
using DotnetMsSqlCICD.Business.Services;
using DotnetMsSqlCICD.Data.Interfaces;

namespace DotnetMsSqlCICD.Test.Business.StudentServiceSpec
{
    public abstract class UsingStudentServiceSpec : SpecFor<StudentService>
    {
        protected IStudentRepository _studentRepository;

        public override void Context()
        {
            _studentRepository = Substitute.For<IStudentRepository>();
            subject = new StudentService(_studentRepository);

        }

    }
}
