using Newtonsoft.Json;
using Parse;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestReq.ViewModels
{
  public class AboutViewModel : BaseViewModel
  {
    public ICommand LoginCommand { get; }

    //This variables has to be set to use Login 
    private const string back4app_server_url = "";
    private  const string back4app_app_id = "";
    private const string clientKey = "";
    


    public AboutViewModel()
    {
      Title = "About";  
      LoginCommand = new Command(async () => await Login());

    }

    public async static Task<bool> Login()
    {

      try
      {

        // Instantiate a ParseClient.
        ParseClient client = new ParseClient(back4app_app_id, back4app_server_url, clientKey);


        //var instal = client.Services.GetCurrentInstallation();
        // Create a user, save it, and authenticate with it.
        await client.SignUpAsync(username: "TestABC", "TestABC");
        //await client.LogInAsync(username: "TestABC", password: "Test");

        // Get the authenticated user. This is can also be done with a variable that stores the ParseUser instance before the SignUp overload that accepts a ParseUser is called.
        var curUser = client.GetCurrentUser();

        return true;

      }
      catch (Exception ex)
      {
        await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "ok");
        return false;
        
      }

    }


  }
}