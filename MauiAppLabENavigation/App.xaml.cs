namespace MauiAppLabENavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");

            MainPage = new AppShell();
        }
    }
}