using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace FoodieFinder;

[Activity(Theme = "@style/Maui.SplashTheme",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density,
    LaunchMode = LaunchMode.SingleTop)]
[IntentFilter(new[] { Intent.ActionView },
    Categories = new[] { Intent.CategoryBrowsable, Intent.CategoryDefault },
    DataScheme = "app",
    DataHost = "foodiefinder",
    DataPathPrefix = "/share-recipe")]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        var recipeID = getSharedRecipeIdFromIntent(Intent);
        if (recipeID != null)
        {
            if (int.TryParse(recipeID, out var id))
                App.SharedRecipeID = id;
            else
                App.SharedOnlineRecipeID = recipeID;
        }
        
        base.OnCreate(savedInstanceState);
    }

    protected override void OnNewIntent(Intent intent)
    {
        base.OnNewIntent(intent);

        var recipeID = getSharedRecipeIdFromIntent(intent);
        if (recipeID != null)
        {
            if (int.TryParse(recipeID, out var id))
                App.SharedRecipeID = id;
            else
                App.SharedOnlineRecipeID = recipeID;

            App.OnSharedRecipeIntentReceived();
        }
    }

    private static string getSharedRecipeIdFromIntent(Intent intent)
    {
        var intentDataStr = intent.Data?.ToString();

        if (intentDataStr != null && intentDataStr.Contains("/share-recipe/"))
            return intentDataStr[(intentDataStr.LastIndexOf("/") + 1)..];

        return null;
    }
}
