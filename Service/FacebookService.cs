using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace FacebookApplication.Service
{
    public class FacebookService
    {
       
        
            private static readonly string PageId = "your-page-id";
            private static readonly string AccessToken = "your-access-token";

            public async Task<string> GetFacebookPostsAsync()
            {
                string url = $"https://graph.facebook.com/{PageId}/posts?access_token={AccessToken}";
                using HttpClient client = new HttpClient();
                var response = await client.GetStringAsync(url);
                var posts = JObject.Parse(response);
                return posts.ToString();
            }
        
    }
}
