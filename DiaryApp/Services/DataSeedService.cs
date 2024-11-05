using DiaryApp.Models;

namespace DiaryApp.Services;

public static class DataSeedService
{
    public static List<DiaryEntry> GetSeedData()
    {
        var dates = Get100RandomDates();

        List<DiaryEntry> seedData = [];
        int counter = 1;
        
        foreach (var date in dates)
        {
            seedData.Add(
                new ()
                {
                    Id = counter,
                    Title = $"Title for Id: {counter}",
                    Content = $"Content for Id: {counter}",
                    Created = date
                });
            
            counter++;
        }
        
        seedData.AddRange([
            new DiaryEntry
            {
                Id = counter + 1,
                Title = "Went Hiking in Jasper, but I just want to see what will happen to a long title",
                Content = "Went hiking to Whistlers Mountain, but I just want to see what will happen to a long content",
                Created = DateTime.Now
            },
            new DiaryEntry
            {
                Id = counter + 2,
                Title = "Went Shopping, but I just want to see what will happen to a long title",
                Content = "Went shopping to Hinton, but I just want to see what will happen to a long content",
                Created = DateTime.Now
            },
            new DiaryEntry
            {
                Id = counter + 3,
                Title = "Went Driving, but I just want to see what will happen to a long title",
                Content = "Went driving to Jasper Driver's school, but I just want to see what will happen to a long content",
                Created = DateTime.Now
            }
        ]);

        return seedData;
    }

    private static DateTime[] Get100RandomDates()
    {
        DateTime[] dates = Enumerable
            .Range(0, 100)
            .Select(offset => DateTime.Today.AddDays(-offset))
            .ToArray();
        
        var random = new Random();
        random.Shuffle(dates);

        return dates;
    }
}