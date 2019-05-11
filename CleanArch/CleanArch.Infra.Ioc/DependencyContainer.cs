using CleanArch.Application.InterFaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Ioc
{
   public class DependencyContainer
    {
        public static void RegiserServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data.Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
