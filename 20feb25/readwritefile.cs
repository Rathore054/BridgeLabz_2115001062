using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class countwords
{
    static void Main()
    {
        try
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader("textfile.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        string lowerWord = word.ToLower();
                        if (wordCount.ContainsKey(lowerWord))
                        {
                            wordCount[lowerWord]++;
                        }
                        else
                        {
                            wordCount.Add(lowerWord, 1);
                        }
                    }
                }
            }

            var topWords = wordCount.OrderByDescending(w => w.Value).Take(5);

            foreach (var word in topWords)
            {
                Console.WriteLine(word.Key + ": " + word.Value);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException: " + ex.Message);
        }
    }
}
