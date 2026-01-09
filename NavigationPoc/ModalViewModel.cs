using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MPowerKit.Navigation.Interfaces;

namespace NavigationPoc;

public partial class ModalViewModel(INavigationService navigationService): ObservableObject
{

    [ObservableProperty] private Color _backgroundColor = Colors.GreenYellow;
    
    [RelayCommand]
    private async Task GoBack()
    {
        await navigationService.GoBackAsync();
    }

    [RelayCommand]
    private void OnGoPink()
    {
        BackgroundColor = Colors.Pink;
    }
}