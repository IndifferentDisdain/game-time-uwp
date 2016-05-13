using System.Collections.ObjectModel;
using System.Windows.Input;
using game_time_uwp.models;
using game_time_uwp.models.Game;

namespace game_time_uwp.lib.ViewModels
{
    public interface IListPageViewModel
    {
        ObservableCollection<GameListItem> Games { get; }

        ICommand NewGameCommand { get; }

        ICommand GameSelectedCommand { get; }

        string NewGameName { get; }

        ObservableCollection<TemplateRosterDto> RosterTemplates { get; }

        TemplateRosterDto SelectedRosterTemplate { get; }
    }
}
