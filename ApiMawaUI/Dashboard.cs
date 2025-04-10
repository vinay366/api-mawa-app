using ApiMawaLibrary;

namespace ApiMawaUI;

public partial class Dashboard : Form
{
    private readonly IApiAcesses api = new ApiAcesses(); //httpclient requires for making api calls
    public Dashboard()
    {
        InitializeComponent();
    }
    private async void callApi_Click(object sender, EventArgs e)
    {
        //vaidate api url
        if(api.isVaildUrl(InputURL.Text)== false)
        {
            apiresults.Text = "Invalid URL! Please Check URL's Once ex: Accpect(starting : https://) || Not Accpect (http://) ";
            SystemStaus.Text = "API Failed Mawa";
            return;
        }

        try
        {
            SystemStaus.Text = "API Loading Mawa...";

            //SystemStaus.Text = await Task.Delay(2000); //wait for 2 seconds to show the loading message

            apiresults.Text= await api.CallApiAsync(InputURL.Text); //call the api and get the response

            SystemStaus.Text = "Ready";

        }
        catch (Exception ex)
        {
            lblResults.Text = "Error: " + ex.Message;
            SystemStaus.Text = "Error";
        }



    }

   
}
