using CommunityToolkit.Mvvm.ComponentModel;

namespace FoodieFinder.Models
{
    public partial class DateColor : ObservableObject
    {
        [ObservableProperty]
        private Color _color;
    }
}
