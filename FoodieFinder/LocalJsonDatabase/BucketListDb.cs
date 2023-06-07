using FoodieFinder.Models;
using System.Text.Json;

namespace FoodieFinder.LocalJsonDatabase
{
    public class BucketListDb
    {
        private static string GetFullPath(int userId) =>
            Path.Combine(FileSystem.Current.AppDataDirectory, $"bucket_list{userId}.json");

        public static List<BucketListItem> GetItems(int userId)
        {
            if (!File.Exists(GetFullPath(userId)))
            {
                return new();
            }

            var jsonContent = File.ReadAllText(GetFullPath(userId));

            if (jsonContent.Length == 0)
            {
                return new();
            }

            return JsonSerializer.Deserialize<List<BucketListItem>>(jsonContent);
        }

        public static void SaveItems(List<BucketListItem> items, int userId)
        {
            var jsonContent = JsonSerializer.Serialize(items);

            File.WriteAllText(GetFullPath(userId), jsonContent);
        }
    }
}
