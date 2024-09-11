using BooksWebApi.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Core.Application.Interfaces.Repository
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        IEnumerable<Entity> GetAll();
        Entity GetById(int id);
        void Add(Entity entity);
        void Update(int oldEntityId, Entity newEntity);
        void Delete(int id);
    }
}
