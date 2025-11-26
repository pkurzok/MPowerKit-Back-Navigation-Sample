using Microsoft.Extensions.Logging;
using MPowerKit.Navigation;
using MPowerKit.Navigation.Utilities;

namespace NavigationPoc;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMPowerKitNavigation(mvvmBuilder =>
            {
                mvvmBuilder
                    .ConfigureServices(services =>
                    {
                        services.RegisterForNavigation<MainPage, MainViewModel>(nameof(MainPage));
                        services.RegisterForNavigation<ModalPage, ModalViewModel>(nameof(ModalPage));
                        services.RegisterForNavigation<SubPage>(nameof(SubPage));
                    })
                    .UsePageEventsInRegions()
                    .OnAppStart(async (_, service) =>
                    {
                        await service.NavigateAsync($"/NavigationPage/{nameof(MainPage)}");
                    });
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
        builder.Logging.SetMinimumLevel(LogLevel.Debug);
#endif

        return builder.Build();
    }
}