using Microsoft.UI.Xaml.Controls;

namespace AppBarButtonIsEnabled;

public sealed partial class ThatOtherPage : Page {
    private GleefullyTogglesItselfWithAbandonCommand GleefullyTogglesItselfWithAbandonCommand { get; set; } = PageWithButtons.Command;

    public ThatOtherPage() {
        InitializeComponent();
    }
}
