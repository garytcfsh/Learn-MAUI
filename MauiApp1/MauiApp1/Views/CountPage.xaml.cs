using MauiApp1.Models;

namespace MauiApp1.Views
{
    public partial class CountPage : ContentPage
    {
        private Count count = Count.Instance;

        public CountPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count.MyCount++;

            // Validation
            if (count.MyCount > 100)
            {
                count.MyCount = 0;
            }

            // ISSUE: Need to know gui control name
            NoDataBindingLabel.Text = $"Clicked {count.MyCount} time";
        }
    }

}
