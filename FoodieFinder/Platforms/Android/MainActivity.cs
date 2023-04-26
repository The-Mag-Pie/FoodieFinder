﻿using Android.App;
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
    DataScheme = "https",
    DataHost = "XXXX",
    DataPathPrefix = "/share-recipe",
    AutoVerify = true)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        var intent = Intent;
        var intentDataStr = intent.Data?.ToString();
        if (intentDataStr != null && intentDataStr.Contains("/share-recipe/"))
        {
            var recipeIDstr = intentDataStr[(intentDataStr.LastIndexOf("/") + 1)..];

            if (int.TryParse(recipeIDstr, out var recipeID))
            {
                App.SharedRecipeID = recipeID;
            }
        }

        base.OnCreate(savedInstanceState);
    }

    protected override void OnNewIntent(Intent intent)
    {
        base.OnNewIntent(intent);
        //MauiApplication.Current.Services
    }
}
