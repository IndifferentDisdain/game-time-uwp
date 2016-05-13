using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using game_time_uwp.lib.Sync;
using game_time_uwp.lib.ViewModels;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace game_time_uwp.Views
{
    public sealed partial class MenuView : UserControl, INotifyPropertyChanged
    {
        public MenuView()
        {
            this.InitializeComponent();
            DataContextChanged += MenuControl_DataContextChanged;
        }

        public IMenuViewModel ConcreteDataContext => DataContext as IMenuViewModel;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void MenuControl_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ConcreteDataContext)));

            ConcreteDataContext.SyncCommand.CanExecuteChanged += SyncCommandOnCanExecuteChanged;
            ConcreteDataContext.SaveCommand.CanExecuteChanged += SaveCommandOnCanExecuteChanged;
        }

        private void SaveCommandOnCanExecuteChanged(object sender, EventArgs e)
        {
            if (ConcreteDataContext.SaveCommand.CanExecute(null))
            {
                SaveIconAnimation.Stop();
            }
            else if (ConcreteDataContext.SaveStatus == SaveStatus.Saving)
            {
                SaveIconAnimation.Begin();
            }
        }

        private void SyncCommandOnCanExecuteChanged(object sender, EventArgs eventArgs)
        {
            if (ConcreteDataContext.SyncCommand.CanExecute(null))
            {
                SyncIconAnimation.Stop();
            }
            else if (ConcreteDataContext.SyncStatus == SyncStatus.Syncing)
            {
                SyncIconAnimation.Begin();
            }
        }
    }
}
