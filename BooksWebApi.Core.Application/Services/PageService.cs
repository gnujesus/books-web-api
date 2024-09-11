using AutoMapper;
using BooksWebApi.Core.Application.DTOs;
using BooksWebApi.Core.Application.Interfaces.Repository;
using BooksWebApi.Core.Application.Interfaces.Service;
using BooksWebApi.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Core.Application.Services
{
    public class PageService : IPageService
    {
        private readonly IPageRepository _repository;
        private readonly IMapper _mapper;

        public PageService(IPageRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public IEnumerable<Page> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
