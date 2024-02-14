using BookStore.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStore.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            StoreContext dbContext = new StoreContext();
            await dbContext.Database.MigrateAsync();
            await StoreContextSeed.SeedAsync(dbContext);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FLoginAdmin());
        }
    }
}