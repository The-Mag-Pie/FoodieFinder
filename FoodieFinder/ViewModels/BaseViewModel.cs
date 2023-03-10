using CommunityToolkit.Mvvm.ComponentModel;

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
        protected async Task TryInvokeAsyncWithIndicator(Func<Task> function)
        {
            if (IsBusy) return;

            IsBusy = true;
            await function.Invoke();
            IsBusy = false;
        }
    }
}
