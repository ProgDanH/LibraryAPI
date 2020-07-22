using LibraryApi.Domain;
using System.Threading.Tasks;

namespace LibraryApi.Controllers
{
    public interface IWriteToMessageQueue
    {
        Task Write(Reservation reservation);
    }
}