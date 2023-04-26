using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;

namespace FoodieFinder.ViewModels
{
    partial class ForgotPasswordPageViewModel : UserAccountViewModel
    {
        private const string API_URL_TEMPLATE = "https://foodiefinder.ydns.eu/api/SendRecoveryEmail/{}";

        public ForgotPasswordPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }

        [RelayCommand]
        private async Task ResetPassword()
        {
            await InvokeAsyncWithLoader(async () =>
            {
                if (Email == null || Email.Length == 0)
                {
                    await DisplayAlert("Error", "Email is empty!", "OK");
                    return;
                }

                var httpClient = _serviceProvider.GetRequiredService<HttpClient>();
                var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();

                int userId;
                try
                {
                    userId = dbContext.User.Where(u => u.Email == Email && u.Password != "auth0").Single().Id;
                }
                catch
                {
                    await DisplayAlert("Error", "User with provided email doesn't exist.", "OK");
                    return;
                }

                try
                {
                    var response = await httpClient.GetStringAsync(API_URL_TEMPLATE.Replace("{}", userId.ToString()));
                    if (response != null && response == "True")
                    {
                        await Application.Current.MainPage.DisplayAlert("Email sent", "Email has been successfully sent. Check your email. Recovery link will be valid during next 15 minutes.", "OK");
                        GoBack();
                    }
                }
                catch
                {
                    await DisplayAlert("Error", "Error during sending an email.", "OK");
                }
            });
        }

    }
}
