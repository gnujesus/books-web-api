using BooksWebApi.Core.Application.DTOs.PageDTOs;
using BooksWebApi.Core.Application.Interfaces.Repository;
using BooksWebApi.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Infrastructure.Persistence.Repositories
{
    public class PageRepository : IPageRepository 
    {
        public List<Page> _pageList = new();

        public void Add(Page book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Page> GetAll()
        {
            return _pageList;
        }

        public Page GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int oldEntityId, Page newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
