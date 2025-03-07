using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp4.Models;

namespace MauiApp4.ViewModels
{
    partial class CountViewModel : ObservableObject
    {
        public static CountViewModel Instance = new CountViewModel();

        public Count CountModel = new Count();

        [ObservableProperty]
        private string msg = string.Empty;

        [ObservableProperty]
        private string msg1 = string.Empty;

        [RelayCommand]
        public void AddCount()
        {
            CountModel.MyCount++;

            // Validation
            if (CountModel.MyCount > 100)
            {
                CountModel.MyCount = 0;
            }

            Msg = $"Clicked {CountModel.MyCount} time";
            Msg1 = $"Clicked {CountModel.MyCount} time";
        }

        [RelayCommand]
        public void AddCountMultipleTimes(object times)
        {
            if (int.TryParse(times.ToString(), out int t))
            {
                CountModel.MyCount = CountModel.MyCount + t;

                // Validation
                if (CountModel.MyCount > 100)
                {
                    CountModel.MyCount = 0;
                }

                Msg = $"Clicked {CountModel.MyCount} time";
                Msg1 = $"Clicked {CountModel.MyCount} time";
            }
        }
    }
}
