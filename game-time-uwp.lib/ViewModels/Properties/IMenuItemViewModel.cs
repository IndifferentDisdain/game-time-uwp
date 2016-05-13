using System.Windows.Input;

namespace game_time_uwp.lib.ViewModels.Properties
{
    public interface IMenuItemViewModel
    {
        string DisplayName { get; }

        string FontIcon { get; }

        ICommand Command { get; }
    }
}
