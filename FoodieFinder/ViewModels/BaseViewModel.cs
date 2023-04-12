using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using FoodieFinder.Popups;

namespace FoodieFinder.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        /// <summary>
        /// Application.Current.MainPage.DisplayAlert(...)
        /// </summary>
        protected static async Task DisplayAlert(string title, string message, string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        /// <summary>
        /// Used for loading indicator
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool _isBusy = false;

        /// <summary>
        /// Used for CanExecute property in RelayCommand
        /// </summary>
        protected bool IsNotBusy => !IsBusy;

        /// <summary>
        /// Set the IsBusy indicator to true, invoke an async function and set the IsBusy indicator to false.
        /// If IsBusy is already set to true, the function won't be invoked.
        /// </summary>
        /// <param name="function">Function to be invoked</param>
        /// <returns></returns>
        protected async Task InvokeAsyncWithLoader(Func<Task> function)
        {
            if (IsBusy) return;

            var popup = new LoadingPopup();

            IsBusy = true;
            Application.Current.MainPage.ShowPopup(popup);

            await function.Invoke();

            popup.Close();
            IsBusy = false;
        }
    }
}
