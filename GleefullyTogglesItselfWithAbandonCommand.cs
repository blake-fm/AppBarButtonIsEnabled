using System.ComponentModel;
using System.Windows.Input;
using Microsoft.UI.Xaml;

namespace AppBarButtonIsEnabled;
public class GleefullyTogglesItselfWithAbandonCommand : ICommand, INotifyPropertyChanged {
    public event EventHandler? CanExecuteChanged;
    public event PropertyChangedEventHandler? PropertyChanged;

    public bool CanExecuteValue { get; private set; } = true;

    public GleefullyTogglesItselfWithAbandonCommand() {
        var timer = new DispatcherTimer {
            Interval = TimeSpan.FromSeconds(2)
        };
        timer.Tick += Toggle;
        timer.Start();
    }

    private void Toggle(object? sender, object e) {
        CanExecuteValue = !CanExecuteValue;
        CanExecuteChanged?.Invoke(this, new());
        PropertyChanged?.Invoke(this, new(nameof(CanExecuteValue)));
    }

    // TODO: ~
    // CanExecute() is called through CsWinRT when a XamlUICommand is Loaded.
    // If it returns false, the CanExecuteChanged event will be ignored until CanExecute is called again (whenever the button is Loaded).
    public bool CanExecute(object? parameter) => CanExecuteValue;

    public void Execute(object? parameter) { }
}
