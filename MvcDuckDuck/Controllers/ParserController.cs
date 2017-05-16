using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace MvcDuckDuck.Controllers
{
    public class ParserController : HomeController
    {
        //
        // GET: /Parser/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        // Создаём экземпляр класса
        HtmlDocument doc = new HtmlDocument();
        public HtmlNode bodyNode;
        public List<string> html = new List<string>();

        public ParserController(String Htmltext)
        {
            doc.LoadHtml(Htmltext);
        }

        public List<string> workParser()
        {
            //string result;

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//html/body/table/tr/td"))
            {
                html.Add(node.ChildNodes[0].InnerText);
                //result = bodyNode.InnerText;
            }
            //cleanResults(html);
            return cleanResults(html);
            //return html;
        }
        private List<string> cleanResults(List<string> dirtyText) {
            List<string> cleanText = new List<string>();
            List<string> cleanText_finaly = new List<string>();
            Regex pattern = new Regex(@"[[:&nbsp;:]]+");
            Regex dump = new Regex(@"[\d\.*\s]+$");

            dirtyText.ForEach(delegate (string item) {
                pattern.Replace(item, ".");
                if(!item.Contains("."))cleanText.Add(item);
            });
                foreach (string value in html)
                {
                    string tmp = value.Replace("&nbsp;", "").Trim();
                    if (tmp != "" && tmp != "\n"&& !(dump.IsMatch(tmp)))
                        cleanText_finaly.Add("Результат: "+tmp + "\n");
                }
            return cleanText_finaly;

        }

        //результат заключен в <tbody> построчно, можно распарсить и вытянуть данные
    }
}
