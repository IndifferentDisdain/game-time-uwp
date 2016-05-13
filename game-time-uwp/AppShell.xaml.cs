using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace game_time_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AppShell : Page
    {
        public AppShell()
        {
            this.InitializeComponent();
        }

        public void SetContentFrame(Frame frame)
        {
            RootSplitView.Content = frame;
        }

        public void SetMenuPaneContent(UIElement content)
        {
            RootSplitView.Pane = content;
        }
    }
}
