using System.Windows.Input;
using game_time_uwp.lib.ViewModels.Properties;

namespace game_time_uwp.lib.ViewModels.DesignTime
{
    public class MenuItemDesignViewModel : IMenuItemViewModel
    {
        public string DisplayName { get; set; }

        public string FontIcon { get; set; }

        public ICommand Command { get; set; }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
