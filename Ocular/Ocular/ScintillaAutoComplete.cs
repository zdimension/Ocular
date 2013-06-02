//Author: Rohan
//Date: 6/2/2013

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScintillaNET;

namespace Ocular
{
    public class ScintillaAutoComplete
    {
        private readonly List<string> keywords;

        public ScintillaAutoComplete()
        {
            keywords = new List<string>();

            //HTML Keywords
            //Feel free to add more
            keywords.Add("button");
            keywords.Add("code");
            keywords.Add("font");
            keywords.Add("form");
            keywords.Add("h");
            keywords.Add("h1");
            keywords.Add("h2");
            keywords.Add("h3");
            keywords.Add("h4");
            keywords.Add("h5");
            keywords.Add("h6");
            keywords.Add("head");
            keywords.Add("html");
            keywords.Add("img");
            keywords.Add("input");
            keywords.Add("link");
            keywords.Add("href");
            keywords.Add("src");
            keywords.Add("title");
        }

        public void EnableAutoComplete(bool enable, Scintilla scintilla)
        {
            int caretPosition = scintilla.Caret.Position;
            string currentWord = scintilla.GetWordFromPosition(caretPosition);

            if (enable)
            {
                scintilla.AutoComplete.Show(currentWord.Length, CheckCurrentWord(scintilla));
            }
            else
            {
                scintilla.AutoComplete.Cancel();
            }
        }

        private string CheckCurrentWord(Scintilla scintilla)
        {
            int caretPosition = scintilla.Caret.Position;
            string currentWord = scintilla.GetWordFromPosition(caretPosition);

            var wordStartsWith = keywords.Where(x => x.StartsWith(currentWord));

            string LOCkeywords = "";

            for (int i = 0; i < wordStartsWith.Count(); ++i)
            {
                if (i != wordStartsWith.Count() - 1)
                {
                    LOCkeywords += wordStartsWith.ElementAt(i) + " ";
                }
                else
                {
                    LOCkeywords += wordStartsWith.ElementAt(i);
                }
            }

            return LOCkeywords;
        }
    }
}
