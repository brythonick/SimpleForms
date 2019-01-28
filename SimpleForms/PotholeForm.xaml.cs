using System.Diagnostics;
using Xamarin.Forms;

namespace SimpleForms
{
    public partial class PotholeForm : ContentPage
    {
        public PotholeForm()
        {
            InitializeComponent();
        }

        async void Submit_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert ("Success", "Your form has been submitted, thank you.", "Okay");
            await Navigation.PopAsync();
        }
    }
}
