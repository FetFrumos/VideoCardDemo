using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwipeCardView.Sample.ViewModel;
using Xamarin.Forms;

namespace VideoCardDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new SimplePageViewModel();
        }
    }
}
