using System.Net;

public static string Run(HttpRequestMessage req, TraceWriter log)
{
    //log.Info($"C# Timer trigger function executed at: {DateTime.Now}");  
    
    string data;
    try
    {
        using (var client = new WebClient())
        {
            // test comment.4
            data = client.DownloadString("https://api.ipify.org?format=json");
        }
    }
    catch (Exception ex)
    {
        data = ex.ToString();
    }
    return data;  
}
