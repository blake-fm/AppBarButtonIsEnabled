using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AppBarButtonIsEnabled;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        AppWindow.ResizeClient(new(640, 480));
    }

    private void GoBack(object sender, RoutedEventArgs e) {
        if (AFrame.CanGoBack) AFrame.GoBack();
    }
    private void GoForward(object sender, RoutedEventArgs e) {
        if (AFrame.CanGoForward) AFrame.GoForward();
    }
}
