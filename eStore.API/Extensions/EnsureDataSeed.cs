using eStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eStore.API.Extensions;

public static class EnsureDataSeed
{
    public static async Task EnsureDataSeeding(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

        try
        {
            await dbContext.Database.MigrateAsync();
            await DataSeed.Seed(dbContext);
        }

        catch (Exception e)
        {
            logger.LogError(e, "Error while migrating process");
        }
    }
}