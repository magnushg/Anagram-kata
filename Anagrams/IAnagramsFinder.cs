using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anagrams
{
    public interface IAnagramsFinder
    {
        Dictionary<string, List<string>> Find();
    }
}
