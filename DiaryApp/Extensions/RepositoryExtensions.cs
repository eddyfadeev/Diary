using DiaryApp.Repository;

namespace DiaryApp.Extensions;

public static class RepositoryExtensions
{
    public static void AddRepository(this IServiceCollection serviceCollection) =>
        serviceCollection.AddScoped<IDiaryEntryRepository, DiaryEntryRepository>();
}