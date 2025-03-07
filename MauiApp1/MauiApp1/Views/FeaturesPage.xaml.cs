using MauiApp1.Resources.Themes;

namespace MauiApp1.Views;

public partial class FeaturesPage : ContentPage
{
	public FeaturesPage()
	{
		InitializeComponent();
	}

    private void Dark_Clicked(object sender, EventArgs e)
    {
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current?.Resources?.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new DarkTheme());
        }
    }

    private void Light_Clicked(object sender, EventArgs e)
    {
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current?.Resources?.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new LightTheme());
        }
    }
}