﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Room
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Layout Layout { get; set; }

    }

    public enum Layout
    {
        Studio,
        OneBedroom,
        TwoBedroom,
    }

}
