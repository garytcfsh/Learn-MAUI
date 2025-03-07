using System.Diagnostics;

namespace MauiApp3.Views;

public partial class TestPage : ContentPage
{
    public string MyText { get; set; } = "Add Times";

	public TestPage()
	{
		InitializeComponent();
	}

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(MyText, out int count))
        {
            Models.Count countModel = Models.Count.Instance;
            Task.Run(() => {
                for (int i = 0; i < count; i++)
                {
                    Thread.Sleep(100);
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        countModel.MyCount++;

                        countModel.Msg =  $"Clicked {countModel.MyCount} time";

                        countModel.Msg1 = $"Clicked {countModel.MyCount} time";

                        Debug.WriteLine($"MyCount={countModel.MyCount}");
                    });
                }
            });
        }
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {

    }
}