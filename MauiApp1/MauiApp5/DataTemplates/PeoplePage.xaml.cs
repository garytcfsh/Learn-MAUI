using System.Collections.ObjectModel;

namespace MauiApp5.DataTemplates;

public partial class PeoplePage : ContentPage
{
	public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>();

	public PeoplePage()
	{
		InitializeComponent();
	}

	int i = 0;

    private void AddBtnClicked(object sender, EventArgs e)
    {
		People.Add(new Person() { Name = $"Person {i}", Age = i, Location = "TW" });
		i++;
		OnPropertyChanged(nameof(People));
    }
}