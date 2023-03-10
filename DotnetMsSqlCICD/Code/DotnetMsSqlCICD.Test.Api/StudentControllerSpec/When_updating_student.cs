using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using DotnetMsSqlCICD.Entities.Entities;

namespace DotnetMsSqlCICD.Test.Api.StudentControllerSpec
{
    public class When_updating_student : UsingStudentControllerSpec
    {
        private ActionResult<Student > _result;
        private Student _student;

        public override void Context()
        {
            base.Context();

            _student = new Student
            {
                name = "name"
            };

            _studentService.Update( _student).Returns(_student);
            
        }
        public override void Because()
        {
            _result = subject.Update( _student);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _studentService.Received(1).Update( _student);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<Student>();

            var resultList = resultListObject as Student;

            resultList.ShouldBe(_student);
        }
    }
}
