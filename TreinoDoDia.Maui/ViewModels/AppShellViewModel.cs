using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TreinoDoDia.Maui.Pages;

namespace TreinoDoDia.Maui.ViewModels;

public partial class AppShellViewModel : ObservableObject
{
    public AppShellViewModel()
    {

    }

    [RelayCommand]
    async Task SignOut()
    {
        await Shell.Current.GoToAsync($"///{nameof(Login)}");
    }
}