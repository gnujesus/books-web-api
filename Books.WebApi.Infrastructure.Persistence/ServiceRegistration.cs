using BooksWebApi.Core.Application.Interfaces.Repository;
using BooksWebApi.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceLayer(this IServiceCollection services)
        {
            services.AddSingleton<IBookRepository, BookRepository>()
            .AddSingleton<IPageRepository, PageRepository>();
        }
    }
}
