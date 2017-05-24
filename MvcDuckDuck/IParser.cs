using System;
using System.Collections.Generic;

namespace MvcDuckDuck
{
    public interface IParser
    {
        List<String> getChet(List<string> input);
        List<String> getNeChet(List<string> input);        
    }
}
