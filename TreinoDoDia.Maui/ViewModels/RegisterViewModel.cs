using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TreinoDoDia.Maui.ViewModels;
public partial class RegisterViewModel : ObservableObject
{
    public RegisterViewModel()
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
    private async Task Register(object obj)
    {
        if (IsValid)
        {
            var result = await App.FirebaseClient.CreateUserWithEmailAndPasswordAsync(Email, Password, App.MetricasCorporais.NomeCompleto);
            if (result != null) return;

            await Shell.Current.GoToAsync("//MainPage");
            return;
        }
        await App.Current.MainPage.DisplayAlert("Erro no cadastro", "Preencha todos os campos", "Ok");
    }
}