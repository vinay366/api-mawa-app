

using System.Text.Json;
using System.Threading.Tasks;

namespace ApiMawaLibrary;

public class ApiAcesses : IApiAcesses //interface for the class
{
    private readonly HttpClient client = new(); //httpclient requires for making api calls
    public async Task<string> CallApiAsync(string url,
        bool formatOutput = true,
        HttpAction action = HttpAction.GET)
    {
        var resonse = await client.GetAsync(url); //get async method is used to get the response from the api

        if (resonse.IsSuccessStatusCode)
        {

            string json = await resonse.Content.ReadAsStringAsync(); //read the response as string

            if (formatOutput) //format the output
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json); //deserialize the json string to json element

                json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }


            return json; //return the response
        }
        else
        {
            return $"Error: {resonse.StatusCode}"; //return the error
        }

    }

    public bool isVaildUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url)) //check if the url is null or empty
        {
            return false;
        }


        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) && (uriOutput.Scheme == Uri.UriSchemeHttps); //check if the url is valid and https
        return output;
    }

}
