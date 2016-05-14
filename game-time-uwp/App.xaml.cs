using System;
using System.Globalization;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using Prism.Unity.Windows;

namespace game_time_uwp
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : PrismUnityApplication
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override async Task OnInitializeAsync(IActivatedEventArgs args)
        {
            //Container.RegisterType<IListPageViewModel, ListPageDesignViewModel>();
            //Container.RegisterType<IMenuViewModel, MenuViewDesignViewModel>();

            await base.OnInitializeAsync(args);
        }

        protected override async Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate(PageTokens.List, null);
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                var viewModelTypeName = string.Format(CultureInfo.InvariantCulture, "game_time_uwp.lib.ViewModels.{0}ViewModel, game-time-uwp.lib, Version=1.0.0.0, Culture=neutral", viewType.Name);
                // First try to find functional viewmodels
                var viewModelType = Type.GetType(viewModelTypeName);
                // If we fail, try finding design-time viewmodels
                // TODO.JS: don't use design-time, but rather demo vms.
                if (viewModelType == null)
                {
                    viewModelTypeName = string.Format(CultureInfo.InvariantCulture, "game_time_uwp.lib.ViewModels.DesignTime.{0}DesignViewModel, game-time-uwp.lib, Version=1.0.0.0, Culture=neutral", viewType.Name);
                    viewModelType = Type.GetType(viewModelTypeName);
                }

                return viewModelType;
            });
        }

        protected override UIElement CreateShell(Frame rootFrame)
        {
            var shell = Container.Resolve<AppShell>();
            shell.SetContentFrame(rootFrame);
            return shell;
        }
    }
}
