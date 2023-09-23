using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace AppBarButtonIsEnabled;

public sealed partial class PageWithButtons : Page {
    private GleefullyTogglesItselfWithAbandonCommand GleefullyTogglesItselfWithAbandonCommand => Command;

    public static GleefullyTogglesItselfWithAbandonCommand Command { get; } = new();

    public PageWithButtons() {
        InitializeComponent();

        Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e) {
        PageLoadStateTextBlock.Text = NaughtyLittleButtonCommand.CanExecute(null).ToString();

        NaughtyLittleButtonCommand.Command.CanExecuteChanged += NaughtyLittleButtonCommand_CanExecuteChanged;
    }

    // TODO: ~
    private void NaughtyLittleButtonCommand_CanExecuteChanged(object? sender, EventArgs e) {
        bool isEnabled = NaughtyLittleButtonCommand.CanExecute(null);
        // If CanExecute() returned false to the framework on Loaded, the following line does nothing.
        NaughtyLittleButton.IsEnabled = isEnabled;
    }
}
