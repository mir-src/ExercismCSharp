using System.Text;
using System.Text.RegularExpressions;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        identifier = Regex.Replace(identifier, @"[\d-]", string.Empty);
        identifier = Regex.Replace(identifier, @"[\d-]", string.Empty);
        var actions = new Dictionary<string, Func<string, string>>
        {
            {@"\s", id => id.Replace(" ", "_")},
            {"\0", id => id.Replace("\0", "CTRL")},
            {"-", ConvertKebabToCamel}
        };

        foreach (var item in actions)
        {
            if (Regex.IsMatch(identifier, item.Key))
            {
                identifier = item.Value(identifier);
            }
        }

        return identifier;
    }
    public static string ConvertKebabToCamel(string id)
    {
        // Split string by '-' 
        var withoutHyphens = id.Split('-');
        // Split returns a string[] array so put the first string in a StringBuilder
        var withCamelCase = new StringBuilder(withoutHyphens[0]);
        // Loop from the second string in the string[] to the end of the string[]
        for (int i = 1; i < withoutHyphens.Length; i++)
        {
            withCamelCase.Append(char.ToUpper(withoutHyphens[i][0]));
            withCamelCase.Append(withoutHyphens[i].Substring(1));
        }
        string result = withCamelCase.ToString();
        return result;
    }
}
