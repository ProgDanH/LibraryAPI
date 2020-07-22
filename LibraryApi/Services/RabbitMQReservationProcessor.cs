using LibraryApi.Controllers;
using LibraryApi.Domain;
using RabbitMqUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Services
{
    public class RabbitMQReservationProcessor : IWriteToMessageQueue
    {
        IRabbitManager Manager;

        public RabbitMQReservationProcessor(IRabbitManager manager)
        {
            Manager = manager;
        }

        public Task Write(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}
