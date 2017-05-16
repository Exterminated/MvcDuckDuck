namespace MvcDuckDuck.Controllers
{
    public class UrlController : HomeController
    {
       

        public string _searchString;
        public string _searchParams;
        public string _resultURL;

        public UrlController() { }

        public UrlController(string input)
        {
            _searchString = generateSearchString(input);          
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
