using AutoMapper;
using LibraryApi.Domain;
using LibraryApi.Models;

namespace LibraryApi.Profiles
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            CreateMap<Book, GetBooksResponseItem>();
        }
    }
}
