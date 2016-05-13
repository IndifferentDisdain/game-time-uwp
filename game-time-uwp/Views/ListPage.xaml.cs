using System.ComponentModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using game_time_uwp.lib.ViewModels;
using game_time_uwp.models.Game;
using Prism.Windows.Mvvm;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace game_time_uwp.Views
{
    public sealed partial class ListPage : SessionStateAwarePage, INotifyPropertyChanged
    {
        public ListPage()
        {
            this.InitializeComponent();
            DataContextChanged += MainPage_DataContextChanged;
        }

        public IListPageViewModel ConcreteDataContext => DataContext as IListPageViewModel;

        public event PropertyChangedEventHandler PropertyChanged;

        private void MainPage_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ConcreteDataContext)));

        private void NewCommand_OnClick(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout(NewCommand);
        }

        private void PreviousGamesList_OnItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedGame = (GameListItem) e.ClickedItem;
            ConcreteDataContext.GameSelectedCommand.Execute(selectedGame);
        }
    }
}
