using System.ComponentModel;
using Xamarin.Forms;
using XamarinLearnApp.ViewModels;

namespace XamarinLearnApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}