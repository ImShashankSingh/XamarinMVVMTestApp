using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestingApp.Views
{
    public partial class MainPage : ContentPage
    {
        ViewModels.MainViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ViewModels.MainViewModel();
        }
    }
}
