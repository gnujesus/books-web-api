using BooksWebApi.Core.Application.DTOs;
using BooksWebApi.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Core.Application.Interfaces.Service
{
    public interface IPageService
    {
        IEnumerable<Page> GetAll();
    }
}
