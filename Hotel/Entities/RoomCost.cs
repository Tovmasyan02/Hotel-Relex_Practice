﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Entities
{
    public class RoomCost
    {
        public int RoomCostId { get; set; }
        [JsonIgnore]public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public int NumberOfSeats { get; set; }
        public bool HasMiniBar { get; set; }
        public int Cost { get; set; }
    }
}
