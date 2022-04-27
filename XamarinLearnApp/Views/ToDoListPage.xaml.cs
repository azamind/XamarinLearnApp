using System;
using Xamarin.Forms;
using XamarinLearnApp.ViewModels;

namespace XamarinLearnApp.Views

{
    public partial class ToDoListPage : ContentPage
    {
        ToDosViewModel _viewModel;

        public ToDoListPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ToDosViewModel();    
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //_viewModel.OnAppearing();
        }
        
        public async void Button_ToDoCreateClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new ToDoCreatePage());
        }

    }
}

