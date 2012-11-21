//Sample license text.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixMessageVisualizer
{
    public interface IFixDictionarySource
    {
         QuickFix.DataDictionary.DataDictionary GetDictionaryForBeginString(string beginString);

    }
}
