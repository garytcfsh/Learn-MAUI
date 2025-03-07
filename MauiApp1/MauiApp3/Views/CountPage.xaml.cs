namespace MauiApp3.Views;

public partial class CountPage : ContentPage
{
    public CountPage()
    {
        InitializeComponent();

        Models.Count mainModel = Models.Count.Instance;
        BindingContext = mainModel;
    }

    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //    if (BindingContext is Models.Count mainModel)
    //    {
    //        mainModel.MyCount++;

    //        NoDataBindingLabel.Text =   $"Clicked {mainModel.MyCount} time";
    //        mainModel.Msg =             $"Clicked {mainModel.MyCount} time";
    //        mainModel.Msg1 =            $"Clicked {mainModel.MyCount} time";
    //    }
    //}
}