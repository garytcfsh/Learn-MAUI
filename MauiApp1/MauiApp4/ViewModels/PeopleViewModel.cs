using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using MauiApp4.DataTemplates;

namespace MauiApp4.ViewModels
{
    partial class PeopleViewModel : ObservableObject
    {
        public static PeopleViewModel Instance = new PeopleViewModel();

        public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>();

        [ObservableProperty]
        private int count = 0;

        [RelayCommand]
        private void AddBtnClicked()
        {
            People.Add(new Person() { Name = $"Person {Count}", Age = Count, Location = "TW" });
            Count++;
        }
    }
}
