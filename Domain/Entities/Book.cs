using BooksWebApi.Core.Domain.Common;
using Swashbuckle.AspNetCore.Annotations; // Swagger attributes

namespace BooksWebApi.Core.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } 
        public string Description { get; set; } 

        public Dictionary<int, Page>? Pages { get; set; } = new Dictionary<int, Page>();
    }
}
