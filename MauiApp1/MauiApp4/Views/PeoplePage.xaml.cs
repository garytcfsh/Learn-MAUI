using MauiApp4.DataTemplates;
using MauiApp4.ViewModels;
using System.Collections.ObjectModel;

namespace MauiApp4.Views;

public partial class PeoplePage : ContentPage
{
	public PeoplePage()
	{
		InitializeComponent();

		BindingContext = PeopleViewModel.Instance;
	}
}