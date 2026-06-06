using Microsoft.Extensions.Logging;
using DnDChar.Windows.Services;
using DnDChar.Windows.ViewModels;
using DnDChar.Windows.Views;

namespace DnDChar.Windows;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Services
        builder.Services.AddSingleton<CharacterService>();
        builder.Services.AddSingleton<ImportExportService>();
        builder.Services.AddSingleton<DiceService>();

        // ViewModels
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<CharacterCreatorViewModel>();
        builder.Services.AddTransient<CharacterSheetViewModel>();
        builder.Services.AddTransient<DiceRollerViewModel>();

        // Pages
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<CharacterCreatorPage>();
        builder.Services.AddTransient<CharacterSheetPage>();
        builder.Services.AddTransient<DiceRollerPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
