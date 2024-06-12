using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TreinoDoDia.Maui.ViewModels;
public partial class LoginViewModel : ObservableObject
{
    public LoginViewModel()
    {
        Email = string.Empty;
        Password = string.Empty;
    }
    [ObservableProperty]
    private string email;

    [ObservableProperty]
    private string password;


    public bool IsValid => !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);


    [RelayCommand]
    private async Task LoginAsync(object obj)
    {
        if (IsValid)
        {
            var result = await App.FirebaseClient.SignInWithEmailAndPasswordAsync(Email, Password);
            if (result != null) return;

            await Shell.Current.GoToAsync("//NomeIdadeView");
            return;
        }
        await App.Current.MainPage.DisplayAlert("Erro de login", "Preencha todos os campos", "Ok");
    }

    [RelayCommand]
    private async Task RegisterAsync()
    {
        await Shell.Current.GoToAsync("//NomeIdadeView");

    }
}