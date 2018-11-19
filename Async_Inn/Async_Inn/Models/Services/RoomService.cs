using Async_Inn.Data;
using Async_Inn.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Services
{
    public class RoomService : IRoom
    {
        private HotelDbContext _context;

        public RoomService(HotelDbContext context)
        {
            _context = context;
        }

        public Task CreateRoom(Room room)
        {
            _context.Rooms.Add(room);
            
        }

        public Task DeleteRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetRoom(int? ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Room>> GetRooms()
        {
            throw new NotImplementedException();
        }

        public Task UpdateRoom(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
