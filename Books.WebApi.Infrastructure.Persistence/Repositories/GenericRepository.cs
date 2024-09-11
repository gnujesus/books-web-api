using BooksWebApi.Core.Application.Interfaces.Repository;
using BooksWebApi.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<Entity> where Entity : BaseEntity, IGenericRepository<Entity>
    {
        // This has test data just to see if the HttpGet is working correctly
        private readonly List<Entity> _entity;

        public GenericRepository(List<Entity> entityList)
        {
            _entity = entityList; 
        }


        public void Add(Entity e)
        {
            _entity.Add(e);
        }

        public Entity GetById(int id)
        {
            return _entity.FirstOrDefault(b => b.Id == id);
        }
        public List<Entity> GetAll()
        {
            return _entity;
        }

        public void Delete(int id)
        {
            Entity book = GetById(id);
            _entity.Remove(book);
        }

        public void Update(Entity book)
        {
            Entity oldBook = GetById(book.Id);
            oldBook = book;
        }

    }
}
