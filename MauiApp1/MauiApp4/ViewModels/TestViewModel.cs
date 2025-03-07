using System.Diagnostics;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp4.ViewModels
{
    partial class TestViewModel : ObservableObject
    {
        private CountViewModel CountViewModel { get; } = CountViewModel.Instance;

        [ObservableProperty]
        private string _text = string.Empty;

        [RelayCommand]
        public void StartTest()
        {
            if (int.TryParse(Text, out int count))
            {
                Task.Run(() => {
                    for (int i = 0; i < count; i++)
                    {
                        Thread.Sleep(100);
                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            CountViewModel.AddCount();
                            Debug.WriteLine($"MyCount={CountViewModel.CountModel.MyCount}");
                        });
                    }
                });
            }
        }
    }
}
