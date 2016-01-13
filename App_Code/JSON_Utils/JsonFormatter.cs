using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Text;


/// <summary>
/// Summary description for JsonFormatter
/// Description: Code from:  http://stackoverflow.com/questions/4580397/json-formatter-in-c
/// </summary>
public class JsonFormatter
{
    public static string Indent = "    ";

    public static string PrettyPrint(string input)
    {
        var output = new StringBuilder(input.Length * 2);
        char? quote = null;
        int depth = 0;

        for (int i = 0; i < input.Length; ++i)
        {
            char ch = input[i];

            switch (ch)
            {
                case '{':
                case '[':
                    output.Append(ch);
                    if (!quote.HasValue)
                    {
                        output.AppendLine();
                        output.Append(Indent.Repeat(++depth));
                    }
                    break;
                case '}':
                case ']':
                    if (quote.HasValue)
                        output.Append(ch);
                    else
                    {
                        output.AppendLine();
                        output.Append(Indent.Repeat(--depth));
                        output.Append(ch);
                    }
                    break;
                case '"':
                case '\'':
                    output.Append(ch);
                    if (quote.HasValue)
                    {
                        if (!output.IsEscaped(i))
                            quote = null;
                    }
                    else quote = ch;
                    break;
                case ',':
                    output.Append(ch);
                    if (!quote.HasValue)
                    {
                        output.AppendLine();
                        output.Append(Indent.Repeat(depth));
                    }
                    break;
                case ':':
                    if (quote.HasValue) output.Append(ch);
                    else output.Append(" : ");
                    break;
                default:
                    if (quote.HasValue || !char.IsWhiteSpace(ch))
                        output.Append(ch);
                    break;
            }
        }

        return output.ToString();
    }
}
