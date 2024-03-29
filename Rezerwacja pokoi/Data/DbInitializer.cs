﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rezerwacja_pokoi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Rezerwacja_pokoi.Data
{
    public class DbInitializer
    {
        public static void Initialize(HotelContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Users.Any())
            {


                var users = new User[]
                {
                new User{ Name="User1", Password= "dfsdf", FirstName="Jan", LastName="Kowal", Email= "cos@wp.pd", Address="ul. Piastowa 10, Poznań 69-200" },
                new User{ Name="User2", Password= "dfsdf", FirstName="Paweł", LastName="Majch", Email= "cos@wp.pd", Address="ul. Akacjowa 12, Warszawa 88-390" },
                new User{ Name="User3", Password= "dfsdf", FirstName="Piotr", LastName="Fort", Email= "cos@wp.pd", Address="ul. Lipowa, Opole 90-445" }
                };

                foreach (User u in users)
                {
                    context.Users.Add(u);
                }
                context.SaveChanges();
            }

            if (!context.Rooms.Any())
            {



                var rooms = new Room[]
                {
                new Room{RoomNumber=3, Description="Pokoj 3 osobowy", BedsCount=3, Location="Parter", Price=300, Rate=4},
                new Room{RoomNumber=41, Description="Pokoj 2 osobowy", BedsCount=1, Location="Pierwsze pietro", Price=230, Rate=5},
                new Room{RoomNumber=62, Description="Pokoj 5 osobowy", BedsCount=5, Location="Drugie pietro", Price=395, Rate=3},
                };
                foreach (Room r in rooms)
                {
                    context.Rooms.Add(r);
                }
                context.SaveChanges();
            }
        }

    }
}
