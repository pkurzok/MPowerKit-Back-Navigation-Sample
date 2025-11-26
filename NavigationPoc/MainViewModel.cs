using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using MPowerKit.Navigation.Interfaces;

namespace NavigationPoc;

public partial class MainViewModel(ILogger<MainViewModel> logger, INavigationService navigationService)
{
    [RelayCommand]
    private async Task OnOpenModal()
    {
        var navigationResult = await navigationService.NavigateAsync(nameof(ModalPage), modal: true);

        if (!navigationResult.Success)
        {
            logger.LogError(navigationResult.Exception, "Failed to open modal page");
        }
        else
        {
            logger.LogDebug("Navigation to Modal: Success");
        }
    }

    [RelayCommand]
    private async Task OnOpenSubPage()
    {
        var navigationResult = await navigationService.NavigateAsync(nameof(SubPage));

        if (!navigationResult.Success)
        {
            logger.LogError(navigationResult.Exception, "Failed to open sub page");
        }
        else
        {
            logger.LogDebug("Navigation to SubPage: Success");
        }
    }
}