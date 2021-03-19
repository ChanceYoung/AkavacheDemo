using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reactive.Linq;
using Akavache;

namespace AkavacheDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BlobCache.Shutdown().Wait();
        }

        async void OnSaveClicked(object sender, EventArgs args)
        {

        }
        async void OnClearClicked(object sender, EventArgs args)
        {

        }
    }
}
