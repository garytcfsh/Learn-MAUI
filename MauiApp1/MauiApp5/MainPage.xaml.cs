namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public string SystemTheme { get; set; } = string.Empty;

        public MainPage()
        {
            InitializeComponent();

            if (Application.Current is Application app)
            {
                AppTheme? currentTheme = app.RequestedTheme;

                SystemTheme = currentTheme?.ToString() ?? "NULL";
                OnPropertyChanged(nameof(SystemTheme));

                app.RequestedThemeChanged += (s, a) =>
                {
                    // Respond to the theme change
                    SystemTheme = a.RequestedTheme.ToString();
                    OnPropertyChanged(nameof(SystemTheme));
                };
            }
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnDarkBtnClicked(object sender, EventArgs e)
        {
            
            if (Application.Current is Application app)
            {
                app.UserAppTheme = AppTheme.Dark;
            }
        }

        private void OnLightBtnClicked(object sender, EventArgs e)
        {
            if (Application.Current is Application app)
            {
                app.UserAppTheme = AppTheme.Light;
            }
        }

        private void OnSystemBtnClicked(object sender, EventArgs e)
        {
            if (Application.Current is Application app)
            {
                app.UserAppTheme = AppTheme.Unspecified;
            }
        }
    }

}
