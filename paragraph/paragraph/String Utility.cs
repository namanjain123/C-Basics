using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paragraph
{
    public static string sumarised(string sentence)
    {
        if (sentence.Length < 20)
        {
            Console.WriteLine(sentence);
        }
        else
        {
            var words = sentence.Split(' ');//We split the text to words
            var totalChar = 0;
            var summaryWords = new List<string>();
            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalChar += word.Length + 1;
                if (totalChar > 20)
                    break;
            }
            var summarry = String.Join(" ", summaryWords) + "...";
            return (summarry);
        }
    }
}
