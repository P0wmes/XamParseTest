using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestReq.Models;
using TestReq.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestReq.Views
{
  public partial class NewItemPage : ContentPage
  {
    public Item Item { get; set; }

    public NewItemPage()
    {
      InitializeComponent();
      BindingContext = new NewItemViewModel();
    }
  }
}