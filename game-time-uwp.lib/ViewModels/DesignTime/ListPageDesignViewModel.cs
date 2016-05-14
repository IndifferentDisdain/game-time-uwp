using System.Collections.ObjectModel;
using System.Windows.Input;
using game_time_uwp.models;
using game_time_uwp.models.Game;
using Prism.Commands;

namespace game_time_uwp.lib.ViewModels.DesignTime
{
    public class ListPageDesignViewModel : IListPageViewModel
    {
        public ListPageDesignViewModel()
        {
            Games = new ObservableCollection<GameListItem>
            {
                new GameListItem {Id = "1", Name = "Yankees 5/12/2016"},
                new GameListItem {Id = "2", Name = "Yankees 5/11/2016"},
                new GameListItem {Id = "3", Name = "Yankees 5/10/2016"},
                new GameListItem {Id = "4", Name = "Yankees 5/9/2016"}
            };
            RosterTemplates = new ObservableCollection<TemplateRosterDto>
            {
                new TemplateRosterDto {Id = "1", Name = "RHP w/ DH"},
                new TemplateRosterDto {Id = "1", Name = "LHP w/ DH"}
            };

            NewGameCommand = new DelegateCommand(OnNewGame);
            GameSelectedCommand = new DelegateCommand(OnGameSelected);
        }

        public ObservableCollection<GameListItem> Games { get; }

        public ICommand NewGameCommand { get; }

        public ICommand GameSelectedCommand { get; }

        public string NewGameName => "Braves 5/13/2016";

        public ObservableCollection<TemplateRosterDto> RosterTemplates { get; }

        public TemplateRosterDto SelectedRosterTemplate => RosterTemplates[0];

        private void OnNewGame() { }

        private void OnGameSelected() { }
    }
}
