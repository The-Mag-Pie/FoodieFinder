using FoodieFinder.Models;
using System.Text.Json;

namespace FoodieFinder.LocalJsonDatabase
{
    public class BucketListDb
    {
        private static readonly string FullPath = Path.Combine(FileSystem.Current.AppDataDirectory, "bucket_list.json");

        public static List<BucketListItem> GetItems()
        {
            if (!File.Exists(FullPath))
            {
                return new();
            }

            var jsonContent = File.ReadAllText(FullPath);

            if (jsonContent.Length == 0)
            {
                return new();
            }

            return JsonSerializer.Deserialize<List<BucketListItem>>(jsonContent);
        }

        public static void SaveItems(List<BucketListItem> items)
        {
            var jsonContent = JsonSerializer.Serialize(items);

            File.WriteAllText(FullPath, jsonContent);
        }
    }
}
