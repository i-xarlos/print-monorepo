using System;
using System.Threading.Tasks;

namespace ModuleOAuthDLL
{
    public class Google
    {
        public Uri GoogleStartUri()
        {
         
             String GoogleClientID = "928081961341-ti71qiq4bcdsc7lbftffh5dr0j3couqu.apps.googleusercontent.com";
             String GoogleCallbackUrl = "urn:ietf:wg:oauth:2.0:oob";
             String GoogleURL = "https://accounts.google.com/o/oauth2/auth?client_id=" + Uri.EscapeDataString(GoogleClientID) + "&redirect_uri=" + Uri.EscapeDataString(GoogleCallbackUrl) + "&response_type=code&scope=" + Uri.EscapeDataString("http://picasaweb.google.com/data");

             Uri StartUri = new Uri(GoogleURL);
             return StartUri;
         
        }

        public Uri GoogleEndUri()
        {
            Uri EndUri = new Uri("https://accounts.google.com/o/oauth2/approval");
            return EndUri;
        }
    }
}
