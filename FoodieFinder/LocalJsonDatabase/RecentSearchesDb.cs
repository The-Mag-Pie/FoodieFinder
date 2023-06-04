using System.Text.Json;

namespace FoodieFinder.LocalJsonDatabase
{
    public class RecentSearchesDb
    {
        private static string GetFullPath(int userId) =>
            Path.Combine(FileSystem.Current.AppDataDirectory, $"recent_searches{userId}.json");

        public static List<string> GetItems(int userId)
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

            return JsonSerializer.Deserialize<List<string>>(jsonContent);
        }

        public static void SaveItems(List<string> items, int userId)
        {
            var jsonContent = JsonSerializer.Serialize(items);

            File.WriteAllText(GetFullPath(userId), jsonContent);
        }

        public static void AddItem(string item, int userId)
        {
            var existingItems = GetItems(userId);
            existingItems.Add(item);

            var jsonContent = JsonSerializer.Serialize(existingItems);
            File.WriteAllText(GetFullPath(userId), jsonContent);
        }
        public static void RemoveItem(string item, int userId)
        {
            var existingItems = GetItems(userId);
            existingItems.Remove(item);

            var jsonContent = JsonSerializer.Serialize(existingItems);
            File.WriteAllText(GetFullPath(userId), jsonContent);
        }
    }
}
