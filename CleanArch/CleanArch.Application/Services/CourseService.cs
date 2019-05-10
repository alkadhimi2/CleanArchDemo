using CleanArch.Application.InterFaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this._courseRepository = courseRepository;
        }
        public CourseViewModel GetCources()
        {
            return new CourseViewModel {
                Courses=_courseRepository.GetCourses()
            };
        }
    }
}
