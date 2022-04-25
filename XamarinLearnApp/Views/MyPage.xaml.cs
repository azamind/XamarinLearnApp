using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLearnApp.Views
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        private void SendButton_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "I was just clicked!";
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            title.Text = "";
            description.Text = "";
            publish.IsToggled = false;
            category.SelectedItem = -1;
        }
    }
}