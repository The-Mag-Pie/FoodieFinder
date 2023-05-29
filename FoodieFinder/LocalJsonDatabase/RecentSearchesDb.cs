using FoodieFinder.Models;
using System.Text.Json;

namespace FoodieFinder.LocalJsonDatabase
{
    public class RecentSearchesDb
    {
        private static readonly string FullPath = Path.Combine(FileSystem.Current.AppDataDirectory, "recent_searches.json");

        public static List<string> GetItems()
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

            return JsonSerializer.Deserialize<List<string>>(jsonContent);
        }

        public static void SaveItems(List<string> items)
        {
            var jsonContent = JsonSerializer.Serialize(items);

            File.WriteAllText(FullPath, jsonContent);
        }

        public static void AddItem(string item)
        {
            var existingItems = GetItems();
            existingItems.Add(item);

            var jsonContent = JsonSerializer.Serialize(existingItems);
            File.WriteAllText(FullPath, jsonContent);
        }
    }
}
