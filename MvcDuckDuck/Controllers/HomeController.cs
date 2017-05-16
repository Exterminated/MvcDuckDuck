using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using MvcDuckDuck;
using System.Text.RegularExpressions;

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
            //Regex rg = new Regex("([ ]*)|((\\n)*)");
            html = ParserModel.getRequestResults();
            foreach (string value in html)
            {
                //string tmp = value.Replace("&nbsp;", "").Trim();
                //if (tmp != "" && tmp != "\n")
                //    res += tmp + "\n";
                res += value;
            }
            //resultTextBox.Text = my_client.sendRequest(url_str);

            //должен браться из модели
            ViewBag.Result = res;

            return View();
           
        }


    }
}
