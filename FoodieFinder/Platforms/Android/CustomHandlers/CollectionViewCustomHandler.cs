using AndroidX.RecyclerView.Widget;
using Microsoft.Maui.Controls.Handlers.Items;

namespace FoodieFinder.Platforms.Android.CustomHandlers
{
    /// <summary>
    /// CollectionView Custom Handler to work around MAUI issue: https://github.com/dotnet/maui/issues/12219
    /// </summary>
    internal class CollectionViewCustomHandler : CollectionViewHandler
    {
        private IItemsLayout ItemsLayout { get; set; }

        protected override IItemsLayout GetItemsLayout()
        {
            return ItemsLayout;
        }

        protected override void ConnectHandler(RecyclerView platformView)
        {
            base.ConnectHandler(platformView);

            ItemsLayout = VirtualView.ItemsLayout;
        }
    }
}
