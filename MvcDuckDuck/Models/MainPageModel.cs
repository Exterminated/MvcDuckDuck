using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDuckDuck.Models
{
    public class MainPageModel
    {
        public MainPageModel() { }
        private List<string> requestResults = new List<string>();
        private int maxRecords = 4;
        public void setMaxRecordsCount(int input) { maxRecords = input; }
        public List<string> getRequestResults() { return requestResults; }
        public void setRequestResults(List<string> input) {
            requestResults.Clear();
            IParser iparser = new IParser();
            int countResults = input.Count();

            //if (maxRecords <= countResults) { requestResults = input.GetRange(0, maxRecords); }
            if (maxRecords <= countResults) { requestResults = iparser.getChet(input); }
            else requestResults = input;            
        }        
        

    }
}