using Firebase.Auth;
using TreinoDoDia.Maui.Config;
using TreinoDoDia.Maui.Models;

namespace TreinoDoDia.Maui;

public partial class App : Application
{
    public static FirebaseAuthClient FirebaseClient { get; } = new FirebaseConfig().FirebaseClient;
    public static MetricasCorporais MetricasCorporais { get; set; } = new MetricasCorporais();
    public App()
    {
        InitializeComponent();
        MainPage = new MainPage();
    }

    protected override async void OnStart()
    {
        base.OnStart();
        SecureStorage.Remove("@treinoData");

        await InitializeAppAsync();
    }


    private async Task InitializeAppAsync()
    {
        var data = await SecureStorage.GetAsync("@treinoData");
        MainPage = new AppShell();

        if (!string.IsNullOrEmpty(data))
        {
            await Shell.Current.GoToAsync("//Login");
        }
        else
        {
            await Shell.Current.GoToAsync("//Login");
            //await Shell.Current.GoToAsync("//NomeIdadeView");
        }
    }
}
