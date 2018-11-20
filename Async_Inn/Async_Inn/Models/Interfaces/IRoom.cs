using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    interface IRoom
    {

        //Create
        Task CreateRoom(Room room);

        //Read
        Task<List<Room>> GetRooms();

        Task<Room> GetRoom(int? ID);

        //Update
        Task UpdateRoom(Room room);

        //Delete
        Task DeleteRoom(int ID);


    }
}
