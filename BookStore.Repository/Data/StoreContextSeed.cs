using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookStore.Repository.Data
{
    public static class StoreContextSeed
    {
        public async static Task SeedAsync(StoreContext _dbContext)
        {
            if (_dbContext.Admins.Count() == 0)
            {
                var adminsData = File.ReadAllText("../../../../BookStore.Repository/Data/DataSeed/admins.json");
                var admins = JsonSerializer.Deserialize<List<Admin>>(adminsData);

                if (admins?.Count() > 0)
                {
                    foreach (var admin in admins)
                        _dbContext.Admins.Add(admin);
                    await _dbContext.SaveChangesAsync();
                } 
            }
        }
    }
}
