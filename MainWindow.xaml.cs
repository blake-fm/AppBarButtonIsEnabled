using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AppBarButtonIsEnabled;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        NavigateToPageWithButtons(null!, null!);
        AppWindow.ResizeClient(new(640, 480));
    }

    private void NavigateToPageWithButtons(object sender, RoutedEventArgs e) => AFrame.Navigate(typeof(PageWithButtons));
    private void NavigateToThatOtherPage(object sender, RoutedEventArgs e) => AFrame.Navigate(typeof(ThatOtherPage));

    private void GoBack(object sender, RoutedEventArgs e) {
        if (AFrame.CanGoBack) AFrame.GoBack();
    }
    private void GoForward(object sender, RoutedEventArgs e) {
        if (AFrame.CanGoForward) AFrame.GoForward();
    }
}
