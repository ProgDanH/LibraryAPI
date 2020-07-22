using LibraryApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Services
{
    public interface IMapBooks
    {
        Task<GetBooksResponse> GetBooks(string genre);
    }
}
