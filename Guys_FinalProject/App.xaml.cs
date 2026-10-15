
namespace Guys_FinalProject;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new LogInPage());
    }
}
