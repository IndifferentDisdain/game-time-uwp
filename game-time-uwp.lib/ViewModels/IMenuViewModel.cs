using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using game_time_uwp.lib.Sync;
using game_time_uwp.lib.ViewModels.Properties;

namespace game_time_uwp.lib.ViewModels
{
    public interface IMenuViewModel
    {
        ICommand SaveCommand { get; }

        ICommand SyncCommand { get; }

        SaveStatus SaveStatus { get; }

        SyncStatus SyncStatus { get; }

        ObservableCollection<IMenuItemViewModel> Commands { get; }

        Symbol SaveSymbol { get; }

        Symbol SyncSymbol { get; }

        string SaveStatusText { get; }

        string SyncStatusText { get; }

        bool IsSaveVisible { get; }
    }
}
