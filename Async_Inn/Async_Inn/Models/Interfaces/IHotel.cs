﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IHotel
    {
        Task<List<Hotel>> GetHotel();

        Task UpdateHotel();
    }
}
