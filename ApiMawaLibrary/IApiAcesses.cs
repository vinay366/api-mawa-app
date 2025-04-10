
namespace ApiMawaLibrary
{
    public interface IApiAcesses
    {
        Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET);
        bool isVaildUrl(string url);
    }
}