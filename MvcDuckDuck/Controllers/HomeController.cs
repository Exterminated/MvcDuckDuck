using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcDuckDuck.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(string search)
        {
            if (search == null)
                return View();

            List<string> html = new List<string>();

            ClientController my_client = new ClientController();
            UrlController my_urls = new UrlController(search);
            string url_str = my_urls.ResultURL;

            ParserController Htmlparser = new ParserController(my_client.sendRequest(url_str));
            
            
            Models.MainPageModel ParserModel = new Models.MainPageModel();

            ParserModel.setRequestResults(Htmlparser.workParser());

            List<string> htmlClean = new List<string>();
            string res = "";
            html = ParserModel.getRequestResults();
            foreach (string value in html)
            {
                res += value;
            }
            //должен браться из модели
            ViewBag.Result = res;

            return View();
           
        }


    }
}
