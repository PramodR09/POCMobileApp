namespace POCBussinessApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            var webView = new WebView
            {
                Source = "https://sasmita2622606.github.io/BusinessApplication"
            };

            webView.Navigated += (s, e) =>
            {
                if (e.Result != WebNavigationResult.Success)
                {
                    DisplayAlert("Error", "Failed to load page.", "OK");
                }
            };

            Content = webView;
        }
    }

}
