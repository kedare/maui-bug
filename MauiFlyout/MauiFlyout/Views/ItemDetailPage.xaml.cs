using System.ComponentModel;
using Xamarin.Forms;
using MauiFlyout.ViewModels;

namespace MauiFlyout.Views
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
