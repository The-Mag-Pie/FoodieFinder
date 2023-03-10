using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FoodieFinder.ViewModels
{
    public partial class SampleViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _sampleParam1;

        [ObservableProperty]
        private string _sampleParam2;

        [ObservableProperty]
        private int _timeout;

        [RelayCommand(CanExecute = nameof(IsNotBusy))]
        private async Task ButtonFirst()
        {
            await TryInvokeAsyncWithIndicator(async () =>
            {
                await Task.Delay(Timeout);

                await DisplayAlert("Przykładowe powiadomienie", SampleParam2, "OK button");
            });
        }
    }
}
