using BooksWebApi.Core.Application.Interfaces.Service;
using BooksWebApi.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Core.Application
{
    public static class ServiceRegistration
    {

        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddTransient<IBookService, BookService>()
            .AddTransient<IPageService, PageService>();
        }
    }
}
