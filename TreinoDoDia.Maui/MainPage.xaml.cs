using System.ComponentModel;

namespace TreinoDoDia.Maui
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private string userInput;
        public string UserInput
        {
            get => userInput;
            set
            {
                userInput = value;
                OnPropertyChanged(nameof(UserInput));
            }
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            CounterBtn.Text = count == 1 ? $"Clicked {count} time" : $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected override void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
