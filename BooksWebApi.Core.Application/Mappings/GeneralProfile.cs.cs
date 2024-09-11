using AutoMapper;
using BooksWebApi.Core.Application.DTOs.BookDTOs;
using BooksWebApi.Core.Application.DTOs.PageDTOs;
using BooksWebApi.Core.Domain.Entities;

namespace BooksWebApi.Core.Application.Mappings
{
    public class GeneralProfile:Profile
    {

        public GeneralProfile()
        {
            #region PagesProfile
            CreateMap<Page, PageDto>()
                .ReverseMap();
            #endregion

            #region BookProfile
            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.Pages, opt => opt.MapFrom(src => src.Pages))
                .ReverseMap(); // Correctly map Pages to List<PageDto>

            CreateMap<Book, SaveBookDto>()
                .ForMember(dest => dest.Pages, opt => opt.MapFrom(src => src.Pages))
                .ReverseMap()
                .ForMember(b => b.Id, opt => opt.Ignore()); // Ignore Id when mapping
            #endregion
        }
    }
}
