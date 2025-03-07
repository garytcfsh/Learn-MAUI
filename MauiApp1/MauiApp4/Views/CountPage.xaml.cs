using MauiApp4.ViewModels;

namespace MauiApp4.Views;

public partial class CountPage : ContentPage
{
    public CountPage()
    {
        InitializeComponent();

        BindingContext = CountViewModel.Instance;
    }
}