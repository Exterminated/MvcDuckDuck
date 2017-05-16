using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDuckDuck
{
    public class IParser
    {
        public IParser() { }
        public List<String> getChet(List<string> input) {
            List<string> result = new List<string>();
            int listLenght = input.Count();
            for (int i = 0; i < listLenght; i++) {
                if (i % 2==0) result.Add(input[i]);
            }
            return result;
        }
        public List<String> getNeChet(List<string> input)
        {
            List<string> result = new List<string>();
            int listLenght = input.Count();
            for (int i = 0; i < listLenght; i++)
            {
                if (i % 2 != 0) result.Add(input[i]);
            }
            return result;
        }        
    }
}