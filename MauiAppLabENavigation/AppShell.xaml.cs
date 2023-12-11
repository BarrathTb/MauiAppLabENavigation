namespace MauiAppLabENavigation
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");

        }
    }
}