using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Model;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx; //private context

        public CourseRepository(UniversityDBContext ctx)
        {
            //ctx is injected context
            _ctx = ctx;//Injecting context to private context
        }
        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }
    }
}
