using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace FactFinderBL;

public static class StringExtensions
{
    public static string GetMiddle(this string input)
    {
        try
        {
            int length = input.Length;
            int middle = length / 2;

            if (length > 1000 || length < 1)
                throw new ArgumentException("Input string cannot be longer than 1000 characters and smaller then 1", nameof(input));

            if (length % 2 == 0)
                return input.Substring(middle - 1, 2);
            else
                return input.Substring(middle, 1);
        }
        catch (Exception ex)
        {
            return $"An error occured: {ex.Message}";
        }


    }
    public static string GetHTMLHeader(this string input)
    {
        try
        {
            var result = string.Empty;
            Match match = Regex.Match(input, @"^(#+)\s{1}([^\s].+)$");
            if (match.Success)
            {
                int level = match.Groups[1].Length;
                string text = match.Groups[2].Value;

                if (level > 6)
                    result = $"{input} (too many hashes)";
                else
                    result = $"<h{level}>{text}</h{level}>";
            }
            else
            {
                if (input.Contains("#"))
                    result = $"{input} (too many spaces between)";
                else
                    result = $"{input} (no hashes)";
            }
            return result;
        }
        catch (Exception ex)
        {
            return $"An error occured: {ex.Message}";
        }
    }

}
