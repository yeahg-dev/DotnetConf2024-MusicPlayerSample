namespace PlayMusic.View;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        this.DataContext = App.ServiceProvider.GetService<ViewModel.PlayerViewModel>();
    }
}
