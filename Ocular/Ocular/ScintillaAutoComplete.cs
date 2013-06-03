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
            keywords.Add(HTMLTags.button);
            keywords.Add(HTMLTags.code);
            keywords.Add(HTMLTags.font);
            keywords.Add(HTMLTags.form);
            keywords.Add(HTMLTags.h);
            keywords.Add(HTMLTags.h1);
            keywords.Add(HTMLTags.h2);
            keywords.Add(HTMLTags.h3);
            keywords.Add(HTMLTags.h4);
            keywords.Add(HTMLTags.h5);
            keywords.Add(HTMLTags.h6);
            keywords.Add(HTMLTags.head);
            keywords.Add(HTMLTags.html);
            keywords.Add(HTMLTags.img);
            keywords.Add(HTMLTags.input);
            keywords.Add(HTMLTags.link);
            keywords.Add(HTMLTags.href);
            keywords.Add(HTMLTags.src);
            keywords.Add(HTMLTags.title);
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
