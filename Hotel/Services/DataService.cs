﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Data;
using Hotel.Entities;

namespace Hotel.Services
{
    public class DataService
    {
        public async void AddUser(User Userx)
        {
            using (HotelContext db = new HotelContext())
            {
                await db.Users.AddAsync(Userx);
                await db.SaveChangesAsync();
            }
        }
    }
}
