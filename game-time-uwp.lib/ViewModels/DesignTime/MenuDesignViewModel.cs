﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using game_time_uwp.lib.Sync;
using game_time_uwp.lib.ViewModels.Properties;

namespace game_time_uwp.lib.ViewModels.DesignTime
{
    public class MenuDesignViewModel : IMenuViewModel
    {
        public MenuDesignViewModel()
        {
            Commands = new ObservableCollection<IMenuItemViewModel>
            {
                new MenuItemDesignViewModel { DisplayName = "Game List", FontIcon = "\ue80f"},
                new MenuItemDesignViewModel { DisplayName = "Positions", FontIcon = "\ue779"},
                new MenuItemDesignViewModel { DisplayName = "Lineup", FontIcon = "\ue719"},
                new MenuItemDesignViewModel { DisplayName = "At Bat", FontIcon = "\ue8ec"},
                new MenuItemDesignViewModel { DisplayName = "Results", FontIcon = "\ue8a9"}
            };
        }
        public ICommand SaveCommand { get; }

        public ICommand SyncCommand { get; }

        public SaveStatus SaveStatus => SaveStatus.Saved;

        public SyncStatus SyncStatus => SyncStatus.Synced;

        public ObservableCollection<IMenuItemViewModel> Commands { get; }

        public Symbol SaveSymbol => Symbol.SaveLocal;

        public Symbol SyncSymbol => Symbol.Sync;

        public string SaveStatusText => "Saved";

        public string SyncStatusText => SyncSymbol.GetDescriptionFromEnumValue();

        public bool IsSaveVisible => true;
    }
}
