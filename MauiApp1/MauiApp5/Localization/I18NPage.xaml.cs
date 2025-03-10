namespace MauiApp5.Localization;

public partial class I18NPage : ContentPage
{
	public I18NPage()
	{
		InitializeComponent();

		MyLabel.Text = AppResources.myLang;
	}
}