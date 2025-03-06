namespace MauiApp3.Views;

public partial class TestPage : ContentPage
{
	public TestPage()
	{
		InitializeComponent();

        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

        LoadNote(Path.Combine(appDataPath, randomFileName));
	}

	private void LoadNote(string fileName)
    {
        Models.Test testModel = new Models.Test();
        testModel.Filename = fileName;

        if (File.Exists(fileName))
        {
            testModel.Date = File.GetCreationTime(fileName);
            testModel.Text = File.ReadAllText(fileName);
        }

        BindingContext = testModel;
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Test testModel)
        {
            testModel.StartTest();
        }
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {

    }
}