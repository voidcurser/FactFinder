/*Question 3/3

Specification
	You are given the following code, to be merged into "production"-running app. 
	Do a review (as thorough as you'd like) and provide suggestions on how to fix the issues (if there are any).
 */


using System;
public class Class1
{
    public static bool IsFormat(string str, string format) // would change the name of the method to be easier to understand what he does for example CheckIfValidFormat or IsValidFormat
    {
        //cover the method with try catch
        var allowedDict = new Dictionary<string, bool>() // instead of bool we can use the Type
        {
            { "number",true}, // here instead of true would stay typeof(int)
            { "date",true},
            { "timespan",true}
        };

        // we need more verification to avoid exceptions for example if input is nullable we can do if (str == null){throw new ArgumentNullException(nameof(str));} 

        // verify size of the input, and return respective result 
       
        /****/
        // we dont need this for we can simply check  if (!allowedFormats.ContainsKey(format)) and if true return an exception
        int isNotAllowed = 0; 
        for (var i = 1; i < allowedDict.Count; i++) 
        {
            if (format == allowedDict.Keys.ToArray()[i - 1])
            {
                isNotAllowed |= 1 << i;
            }
        }

        if (isNotAllowed > 0)
            throw new Exception("Format not allowed.");
        /****/
        // we can get the expected format we desire from the dictionary(with the change pointed on top) and then compare the type for example  Type expectedType = allowedFormats[format]; and then 
        if (format.ToLower() == "number") //expectedType == typeof(int) and so on for the other ifs
            return Int32.TryParse(str, out var _);
        else if (format.ToLower() == "date")
            return DateTime.TryParse(str, out var _);
        else if (format.ToLower() == "timespan")
            return DateTime.TryParse(str, out var _);

        throw new Exception("Unknown format.");// and here the message can be more complete so the user understands better right away what the problem was
    }

}


