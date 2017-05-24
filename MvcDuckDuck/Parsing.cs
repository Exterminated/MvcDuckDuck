using System.Collections.Generic;

namespace MvcDuckDuck
{
    class Parsing : IParser
    {
        public Parsing() { }

        public List<string> getChet(List<string> input)
        {
            List<string> result = new List<string>();
            int listLenght = input.Count;
            for (int i = 0; i < listLenght; i++)
            {
                if (i % 2 == 0) result.Add(input[i]);
            }
            return result;
        }

        public List<string> getNeChet(List<string> input)
        {
            List<string> result = new List<string>();
            int listLenght = input.Count;
            for (int i = 0; i < listLenght; i++)
            {
                if (i % 2 != 0) result.Add(input[i]);
            }
            return result;
        }
        
    }
}
