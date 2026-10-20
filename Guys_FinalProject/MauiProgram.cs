
namespace Guys_FinalProject;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("PlayfairDisplayt.ttf", "PlayfairDisplayt");
                fonts.AddFont( "OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont( "OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("PlayfairDisplay11.ttf", "PlayfairDisplay11");
            });

        return builder.Build();
    }
}
