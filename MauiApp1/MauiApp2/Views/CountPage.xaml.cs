namespace MauiApp2.Views;

public partial class CountPage : ContentPage
{
    public CountPage()
    {
        InitializeComponent();

        BindingContext = Models.Count.Instance;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Count mainModel)
        {
            mainModel.MyCount++;

            if (mainModel.MyCount > 100)
            {
                mainModel.MyCount = 0;
            }

            NoDataBindingLabelA.Text =   $"Clicked {mainModel.MyCount} time";
            NoDataBindingLabelB.Text =   $"Clicked {mainModel.MyCount} time";

            mainModel.Msg =              $"Clicked {mainModel.MyCount} time";

            mainModel.Msg1 =             $"Clicked {mainModel.MyCount} time";
        }
    }
}