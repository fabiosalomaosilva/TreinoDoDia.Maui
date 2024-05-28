namespace TreinoDoDia.Maui.Components;

public partial class TextBox : ContentView
{
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(TextBox), default(string), BindingMode.TwoWay);

    public static readonly BindableProperty PlaceholderProperty =
        BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(TextBox), default(string));

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public TextBox()
    {
        InitializeComponent();
    }

    void OnEntryFocused(object sender, FocusEventArgs e)
    {
        Frame.BorderColor = Colors.Blue;
    }

    void OnEntryUnfocused(object sender, FocusEventArgs e)
    {
        Frame.BorderColor = Colors.Gray;
    }
}