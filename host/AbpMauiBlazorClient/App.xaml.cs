namespace AbpMauiBlazorClient
{
    public partial class App : Application
    {
        public const string CallbackUri = "abpmauiblazor://";

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}