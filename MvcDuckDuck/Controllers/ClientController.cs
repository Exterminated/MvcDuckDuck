using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Text;
using System.Net;
using System.IO;

namespace MvcDuckDuck.Controllers
{
    public class ClientController : HomeController
    {
        //
        // GET: /Client/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ClientController() { }

        public string sendRequest(string request)
        {
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

            Uri uri = new Uri("https://duckduckgo.com/lite" + request);

            try
            {
                WebRequest webRequest = WebRequest.Create(uri);
                WebResponse webResponse = webRequest.GetResponse();

                Stream dataStream = webResponse.GetResponseStream();
                //testSaveToFile(dataStream);
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();

                // Clean up the streams and the response.
                reader.Close();
                webResponse.Close();

                return responseFromServer;
            }
            catch (Exception ex) { return ex.ToString(); }
        }

        //private void testSaveToFile(Stream stream) {
        //    var fileStream = File.Create("response.txt");
        //    stream.CopyTo(fileStream);
        //    fileStream.Close();
        //}

        public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

    }
}
