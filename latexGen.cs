using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Encodings.Web;
using System.Web;
using System.Globalization;

namespace ActViewer
{
    internal class latexGen
    {
        /// <summary>
        /// Takes plain text following the standard format and converts it into a standard format LaTEX file.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        /// 
        public static string parseText(string? text, string regnalYear, bool original)
        {

            bool IsAllUpper(string input)
            {
                if (input != "")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (Char.IsLetter(input[i]) && !Char.IsUpper(input[i]))
                            return false;
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }

            try
            {
                TextInfo TI = new CultureInfo("en-UK", false).TextInfo;
                if (text == null)
                {
                    throw new Exception("Null input text into the LaTEX parser.");
                }
                else if (text == "")
                {
                    throw new Exception("Empty input text into the LaTEX parser.");
                }
                else if (text.Contains(@"\rtf"))
                {
                    throw new Exception("Pre-formatted text was inputted into the LaTEX parser.");
                }
                else
                {
                    string[] lines = text.Split('\n');

                    #region Get chapter
                    string[] firstLineWords = lines[0].Split(' ');
                    int chapter = int.Parse(firstLineWords[1]);
                    #endregion
                    #region Get long title
                    string longTitle = "";
                    for (var i = 3; i < firstLineWords.Count(); i++)
                    {
                        longTitle = string.Join(' ', longTitle, firstLineWords[i]);
                    }
                    longTitle = longTitle.Trim();
                    longTitle = TI.ToTitleCase(longTitle);
                    #endregion
                    #region Get status
                    string status = "";
                    if (original) { status = "As originally enacted"; } else { status = "As amended"; }
                    #endregion
                    #region Parse lines

                    for (int i = 2; i < lines.Count(); ++i)
                    {
                        if (IsAllUpper(lines[i]))
                        {
                            
                            lines[i] = TI.ToTitleCase(lines[i]);
                            if (lines[i].StartsWith('-'))
                            {
                                string _hdr = "";
                                foreach (var c in lines[i])
                                {
                                    if (c != '-') { _hdr += c; }
                                }
                                lines[i] = @"\subsection{" + _hdr + "}";
                            }
                            else
                            {
                                lines[i] = @"\section{" + lines[i] + "}";
                            }
                        }
                    }
                    #endregion

                    List<String> lineList = lines.ToList();

                    lineList.RemoveRange(0, 1);

                    return "\\documentclass[12pt,letterpaper,titlepage]{report}\r\n\\usepackage[utf8]{inputenc}\r\n\\author{Parliament of Baustralia}\r\n\\title{" + longTitle + "}\r\n" +
                    "\\date{" + regnalYear + ", chapter " + chapter.ToString() + "\\\\" + status + "}\r\n\\begin{document}\r\n\\maketitle\r\n" + String.Join("\r\n", lineList) + "\r\n\\end{document}";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured while generating the LaTEX document.\r\nThis is a program error not caused by the user. Please report to the Communications Office.\r\n" + e.Message, "LaTEX error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

    }
}
