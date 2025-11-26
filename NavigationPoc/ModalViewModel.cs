using CommunityToolkit.Mvvm.Input;
using MPowerKit.Navigation.Interfaces;

namespace NavigationPoc;

public partial class ModalViewModel(INavigationService navigationService)
{
    [RelayCommand]
    private async Task GoBack()
    {
        await navigationService.GoBackAsync();
    }
}