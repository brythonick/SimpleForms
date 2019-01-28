using Xamarin.Forms;

namespace SimpleForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void PotholeForm_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PotholeForm());
        }

        async void BinCollection_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BinCollection());
        }
    }
}
