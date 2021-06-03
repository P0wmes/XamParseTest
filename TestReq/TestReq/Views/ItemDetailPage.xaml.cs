using System.ComponentModel;
using TestReq.ViewModels;
using Xamarin.Forms;

namespace TestReq.Views
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