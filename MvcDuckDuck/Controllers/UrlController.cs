using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Threading.Tasks;

namespace MvcDuckDuck.Controllers
{
    public class UrlController : HomeController
    {
        //
        // GET: /Url/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string _searchString;
        public string _searchParams;
        public string _resultURL;

        public UrlController() { }

        public UrlController(string input /*int input_params*/)
        {
            _searchString = generateSearchString(input);
            //_searchParams = generateParams(input_params);            
        }
        public string ResultURL
        {
            get
            {
                return _resultURL = generateURL();
            }
        }
        public string generateSearchString(string str)
        {
            return str = str.Replace(' ', '+');
        }
        public string generateParams(int param)
        {
            string result = "";

            switch (param)
            {
                case 0:
                    {
                        result = "";
                        break;
                    }
                case 1:
                    {
                        result = "&df=d";
                        break;
                    }
                case 2:
                    {
                        result = "&df=w";
                        break;
                    }
                case 3:
                    {
                        result = "&df=m";
                        break;
                    }
            }
            return result;
        }

        public string generateURL()
        {
            string searchRequest = @"/?q=" + _searchString + "&t=hb" + _searchParams + "&ia=web";
            return searchRequest;
        }

    }
}
