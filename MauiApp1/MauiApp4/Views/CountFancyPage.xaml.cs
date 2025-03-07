using MauiApp4.ViewModels;

namespace MauiApp4.Views;

public partial class CountFancyPage : ContentPage
{
	public CountFancyPage()
	{
		InitializeComponent();

        BindingContext = CountViewModel.Instance;
	}
}